using Egyptos.Application.Abstractions;
using Egyptos.Application.Contracts;
using Egyptos.Application.Contracts.Payment;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.Transport.PrivateTransports;
using Egyptos.Domain.Errors.PrivateTransport;
using Egyptos.Domain.Helpers;
using Egyptos.Domain.Interfaces;
using Hangfire;
using Microsoft.Extensions.Configuration;
using NETCore.MailKit.Core;
using static Egyptos.Domain.Consts.DefaultRoles;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Egyptos.Application.Services.Implementations;

public class BookingPrivateTransportService(
    ApplicationDbContext _context,
    IPayment _payment,
    IConfiguration _configuration,
    IEmailSender emailSender,
    IHttpContextAccessor httpContextAccessor) : IBookingPrivateTransportService
{
    private readonly IEmailSender _emailSender = emailSender;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId, PaymentRequest paymentRequest)
    {
        var booking = await _context.BookingPrivateTransports
            .Include(x => x.PrivateTransport)
            .FirstOrDefaultAsync(x => x.Id == bookingId);

        if (booking is null)
            return Result.Failure<CheckOutOrderResponse>(BookingPrivateTransportError.NotFound);

        if (booking.PaymentDate.HasValue)
            return Result.Failure<CheckOutOrderResponse>(PaymentError.AlreadyPeyment);

        //TODO : add stipe payment
        var sessionId = await _payment.ProcessPayment(booking, paymentRequest);

        var result = new CheckOutOrderResponse
        {
            SessionId = sessionId,
            PubKey = _configuration["Stripe:PubKey"]!
        };

        return Result.Success(result);
    }

    public async Task<Result> MarkAsPaidAsync(int bookingId)
    {
        if (await _context.BookingPrivateTransports.Include(x => x.PrivateTransport).Include(x=>x.User).FirstOrDefaultAsync(x => x.Id == bookingId) is not { } booking)
            return Result.Failure(BookingPrivateTransportError.NotFound);

        booking.PaymentDate = DateTime.UtcNow;

        booking.PrivateTransport.Quantity -= 1;
        BackgroundJob.Schedule(() => PlusTransportQuantity(booking.PrivateTransportId), booking.End);

        var notificationPaymentResponse=booking.Adapt<NotificationPaymentResponse>();
        notificationPaymentResponse.NameOfBooking=nameof(booking.PrivateTransport);
        await SendNotificationPaymentIsSuccesToUserByEmail(notificationPaymentResponse, "");

        await _context.SaveChangesAsync();

        return Result.Success(booking);
    }


    public async Task<Result<List<BookingPrivateTransportResponse>>> GetAllAsync()
    {
        var Bookings = await _context.BookingPrivateTransports
            .ProjectToType<BookingPrivateTransportResponse>()
            .ToListAsync();

        if (!Bookings.Any())
            return Result.Failure<List<BookingPrivateTransportResponse>>(BookingPrivateTransportError.NotFound);

        return Result.Success(Bookings);
    }

    public async Task<Result<List<BookingPrivateTransportResponse>>> GetAllForUserAsync(string userId)
    {
        var Bookings = await _context.BookingPrivateTransports
            .Where(x => x.UserId == userId)
            .ProjectToType<BookingPrivateTransportResponse>()
            .ToListAsync();

        if (!Bookings.Any())
            return Result.Failure<List<BookingPrivateTransportResponse>>(BookingPrivateTransportError.NotFound);

        return Result.Success(Bookings);
    }

    public async Task<Result<BookingPrivateTransportResponse>> GetAsync(int id)
    {
        var booking = await _context.BookingPrivateTransports
            .Where(x => x.Id == id)
            .Include(x => x.User)
            .Include(x => x.PrivateTransport)
            .ProjectToType<BookingPrivateTransportResponse>()
            .FirstOrDefaultAsync();

        if (booking is null)
            return Result.Failure<BookingPrivateTransportResponse>(BookingPrivateTransportError.NotFound);

        var bookingMapped = booking.Adapt<BookingPrivateTransportResponse>();

        return Result.Success(bookingMapped);
    }

    public async Task<Result<BookingPrivateTransportResponse>> CreateAsync(string userId, BookingPrivateTransportRequest request)
    {
        if (await _context.PrivateTransports.FindAsync(request.PrivateTransportId) is not { } privateTransport)
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.NotFound);

        if (!privateTransport.IsAvailable)
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.NotAvilable);

        if (await _context.BookingPrivateTransports.AnyAsync(x => x.UserId == userId && !x.PaymentDate.HasValue))//***
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.AlreadyHaveBooked);

        var booking = request.Adapt<BookingPrivateTransport>();

        var priceHour = privateTransport.PricePerHour;


        // calc booking price
        TimeSpan timeSpan = request.End - request.Start;
        double totalHours = Math.Abs(timeSpan.TotalHours);
        booking.TotalPrice = totalHours * priceHour;


        booking.UserId = userId;

        await _context.BookingPrivateTransports.AddAsync(booking);
        await _context.SaveChangesAsync();

        var result = booking.Adapt<BookingPrivateTransportResponse>();

        result.PricePerHour = priceHour;

        return Result.Success(result);
    }

    public async Task<Result> UpdateAsync(int id, BookingPrivateTransportRequest request)
    {
        var booking = await _context.BookingPrivateTransports.Include(x => x.PrivateTransport).FirstOrDefaultAsync(x => x.Id == id);

        if (booking is null)
            return Result.Failure<BookingPrivateTransportResponse>(BookingPrivateTransportError.NotFound);

        if (await _context.PrivateTransports.FirstOrDefaultAsync(x => x.Id == request.PrivateTransportId) is not { } privateTransport)
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.NotFound);

        if (!privateTransport.IsAvailable)
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.NotAvilable);

        if (booking.PaymentDate.HasValue)
            //return Result.Failure<BookingPrivateTransportResponse>(PaymentError.NotFound); //****
            return Result.Failure<BookingPrivateTransportResponse>(PaymentError.AlreadyPeyment); //****

        var pricePerHour = booking.PrivateTransport.PricePerHour;

        booking = request.Adapt(booking);


        TimeSpan timeSpan = request.End - request.Start;

        double totalHours = Math.Abs(timeSpan.TotalHours);

        booking.TotalPrice = totalHours * (double)pricePerHour;


        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> CancelBookingAsync(int id)
    {
        var booking = await _context.BookingPrivateTransports.FindAsync(id);

        if (booking is null)
            return Result.Failure(BookingPrivateTransportError.NotFound);

        if (booking.PaymentDate.HasValue)
            return Result.Failure(PaymentError.AlreadyPeyment);

        if (booking.PaymentCancel.HasValue || booking.CancelBooking.HasValue)
            return Result.Failure(PaymentError.AlreadyCancel);

        BackgroundJob.Schedule(() => PlusTransportQuantity(booking.PrivateTransportId), booking.Start);

        booking.CancelBooking = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task MinusTransportQuantity(int privateTransportId)
    {
        await _context.PrivateTransports.ExecuteUpdateAsync(setters => setters
            .SetProperty(p => p.Quantity, p => p.Quantity - 1)
            .SetProperty(p => p.IsAvailable, p => (p.Quantity - 1) > 0)
        );
    }

    public async Task PlusTransportQuantity(int privateTransportId)
    {
        await _context.PrivateTransports.Where(p => p.Id == privateTransportId)
            .ExecuteUpdateAsync(setters => setters
                .SetProperty(p => p.Quantity, p => p.Quantity + 1)
                .SetProperty(p => p.IsAvailable, p => (p.Quantity + 1) > 0)
            );
    }

    private async Task SendNotificationPaymentIsSuccesToUserByEmail(NotificationPaymentResponse response, string code)
    {
        var origin = _httpContextAccessor.HttpContext?.Request.Headers.Origin;
       
        var emailBody = EmailBodyBuilder.GenerateEmailBody("PaymenNotification.html",
            templateModel: new Dictionary<string, string>
            {
                { "{{BookingId}}", response.BookingId.ToString() },
                { "{{BookingType}}", response.NameOfBooking },
                { "{{BookingName}}", response.PrivateTransportName },
                { "{{UserName}}", response.UserName },
                { "{{Start}}", response.Start.ToString() },
                { "{{End}}", response.End.ToString() },
                { "{{TotalPrice}}", response.TotalPrice.ToString() },
                { "{{PaymentDate}}", response.PaymentDate.ToString()! },
            }
        );

        BackgroundJob.Enqueue(() => _emailSender.SendEmailAsync(
       response.UserEmail, // Assuming you have user email in the response, or get it from user service
       $"✅ Payment Successful - {response.PrivateTransportName} Booking Confirmed",
       emailBody));

        await Task.CompletedTask;
    }
}

//public static class JobRegistry
//{
//    private static readonly Dictionary<string, string> JobNameToId = new();

//    public static void Register(string name, string jobId)
//    {
//        JobNameToId[name] = jobId;
//    }

//    public static string? GetJobId(string name)
//    {
//        return JobNameToId.TryGetValue(name, out var jobId) ? jobId : null;
//    }

//    public static void Remove(string name)
//    {
//        JobNameToId.Remove(name);
//    }
//}
