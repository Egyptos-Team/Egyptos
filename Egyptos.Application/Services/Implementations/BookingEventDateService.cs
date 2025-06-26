using Egyptos.Application.Contracts;
using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.Payment;
using Egyptos.Domain.Helpers;
using Hangfire;
using Microsoft.Extensions.Configuration;

namespace Egyptos.Application.Services.Implementations;

public class BookingEventDateService(ApplicationDbContext context,
    IPayment _payment,
    IConfiguration _configuration,
     IEmailSender emailSender,
    IHttpContextAccessor httpContextAccessor) : IBookingEventDateService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IEmailSender _emailSender = emailSender;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result> BookATicket(string userId, int eventDateId)
    {
        if (await _context.EventDates.FindAsync(eventDateId) is not { } eventDate)
            return Result.Failure<EventDateResponse>(EventErrors.EventDateNotFount);

        var bookingIsExisting = await _context.BookingEventDates.AnyAsync(x => x.EventDateId == eventDateId && x.UserId == userId);
        if (bookingIsExisting)
            return Result.Failure(EventErrors.DuplicatedBooking);

        var bookingventDate = new BookingEventDate
        {
            EventDateId = eventDateId,
            UserId = userId
        };

        await _context.BookingEventDates.AddAsync(bookingventDate);
        await _context.SaveChangesAsync();

        return Result.Success();
    }
    public async Task<IEnumerable<BookingEventDateRasponse>> GetAllAsync() =>
           await _context.BookingEventDates
                .Include(x => x.EventDate)
                .ThenInclude(x => x.Event)
                .ProjectToType<BookingEventDateRasponse>()
                .AsNoTracking()
                .ToListAsync();
    public async Task<Result<BookingEventDateByUserRasponse>> BookedByUserAsync(string userId)
    {
        var IsExistingUser = await _context.BookingEventDates.AnyAsync(x => x.UserId == userId);
        if (!IsExistingUser)
            return Result.Failure<BookingEventDateByUserRasponse>(EventErrors.UserNotBooked);


        var bookingEventDate = new BookingEventDateByUserRasponse
        (
            UserId: userId,
            EventDates: await _context.BookingEventDates
                .Where(x => x.UserId == userId)
                .Include(x => x.EventDate)
                .ThenInclude(x => x.Event)
                .Select(x => x.EventDate)
                .ProjectToType<EventDateResponseBooking>()
                .AsNoTracking()
                .ToListAsync()
        );

        return Result.Success(bookingEventDate);
    }
    public async Task<Result<BookingEventDateEventBooked>> EventBookedAsync(int eventDateId)
    {
        var IsExistingEventDate = await _context.BookingEventDates.AnyAsync(x => x.EventDateId == eventDateId);
        if (!IsExistingEventDate)
            return Result.Failure<BookingEventDateEventBooked>(EventErrors.EventNotBooked);


        var bookingEventDate = new BookingEventDateEventBooked
        (
            EventDateId: eventDateId,
            Users: await _context.BookingEventDates
                .Where(x => x.EventDateId == eventDateId)
                .Include(x => x.User)
                .Select(x => x.User)
                .ProjectToType<AuthResponse>()
                .AsNoTracking()
                .ToListAsync()
        );

        return Result.Success(bookingEventDate);
    }
    public async Task<Result> DeleteAsync(string userId, int eventDateId)
    {
        var isExstingBookinEventDate = await _context.BookingEventDates
            .AnyAsync(x => x.EventDateId == eventDateId && x.UserId == userId);
        if (!isExstingBookinEventDate)
            return Result.Failure(EventErrors.BookingNotFount);

        _context.BookingEventDates.Remove(new BookingEventDate { UserId = userId, EventDateId = eventDateId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }

    //public async Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId, PaymentRequest paymentRequest)
    //{
    //    //var booking = await _context.BookingEventDates
    //    //    .Include(x => x.EventDate)
    //    //    .ThenInclude(x => x.EventImages)
    //    //    .FirstOrDefaultAsync(x => x.Id == bookingId);

    //    //if (booking is null)
    //    //    return Result.Failure<CheckOutOrderResponse>(EventErrors.BookingNotFount);

    //    //if (booking.PaymentDate.HasValue)
    //    //    return Result.Failure<CheckOutOrderResponse>(PaymentError.AlreadyPeyment);


    //    //var sessionId = await _payment.ProcessPayment(booking, paymentRequest);

    //    //var result = new CheckOutOrderResponse
    //    //{
    //    //    SessionId = sessionId,
    //    //    PubKey = _configuration["Stripe:PubKey"]!
    //    //};

    //    //return Result.Success(result);
    //}

    //public async Task<Result> MarkAsPaidAsync(int bookingId)
    //{
    //    if (await _context.BookingEventDates
    //        .Include(e=> e.EventDate)
    //        .ThenInclude(x => x.Event)
    //        .Include(u=>u.User)
    //        .FirstOrDefaultAsync(x => x.Id == bookingId ) is not { } booking)
    //        return Result.Failure(EventErrors.BookingNotFount);

    //    booking.PaymentDate = DateTime.UtcNow;

    //    var notificationPaymentResponse = new NotificationPaymentResponse
    //    {
    //        NameOfBooking = nameof(booking.EventDate.Event.Name),
    //        BookingId = bookingId,
    //        UserName=booking.User.FirstName + " " + booking.User.LastName,
    //        UserEmail=booking.User.Email!,
    //        Start=booking.EventDate.StartDate,
    //        End=booking.EventDate.EndDate,
    //        TotalPrice=booking.EventDate.Price,
    //        PaymentDate=DateTime.UtcNow,
    //        ItemName=booking.EventDate.Event.Name

    //    };
    //    await SendNotificationPaymentIsSuccesToUserByEmail(notificationPaymentResponse, "");

    //    await _context.SaveChangesAsync();

    //    return Result.Success(booking);
    //}

    private async Task SendNotificationPaymentIsSuccesToUserByEmail(NotificationPaymentResponse response, string code)
    {
        var origin = _httpContextAccessor.HttpContext?.Request.Headers.Origin;

        var emailBody = EmailBodyBuilder.GenerateEmailBody("PaymenNotification.html",
            templateModel: new Dictionary<string, string>
            {
                { "{{BookingId}}", response.BookingId.ToString() },
                { "{{BookingType}}", response.NameOfBooking },
                { "{{BookingName}}", response.ItemName },
                { "{{UserName}}", response.UserName },
                { "{{Start}}", response.Start.ToString() },
                { "{{End}}", response.End.ToString() },
                { "{{TotalPrice}}", response.TotalPrice.ToString() },
                { "{{PaymentDate}}", response.PaymentDate.ToString()! },
            }
        );

        BackgroundJob.Enqueue(() => _emailSender.SendEmailAsync(
       response.UserEmail, // Assuming you have user email in the response, or get it from user service
       $"✅ Payment Successful - {response.ItemName} Booking Confirmed",
       emailBody));

        await Task.CompletedTask;
    }

    public Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId, PaymentRequest paymentRequest)
    {
        throw new NotImplementedException();
    }

    public Task<Result> MarkAsPaidAsync(int bookingId)
    {
        throw new NotImplementedException();
    }
}
