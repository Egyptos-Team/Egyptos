using Egyptos.Application.Contracts.Payment;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.Transport.PrivateTransports;
using Egyptos.Domain.Errors.PrivateTransport;
using Hangfire;
using Microsoft.Extensions.Configuration;

namespace Egyptos.Application.Services.Implementations;

public class BookingPrivateTransportService(
    ApplicationDbContext _context,
    IPayment _payment,
    IConfiguration _configuration) : IBookingPrivateTransportService
{

    public async Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId, PaymentRequest paymentRequest)
    {
        var booking = await _context.BookingPrivateTransports
            .Include(x => x.PrivateTransport)
            .FirstOrDefaultAsync(x => x.Id == bookingId);

        if (booking is null)
            return Result.Failure<CheckOutOrderResponse>(BookingPrivateTransportError.NotFound);

        if (booking.PaymentDate.HasValue)
            return Result.Failure<CheckOutOrderResponse>(PaymentError.AlreadyPeyment);


        if (!booking.End.HasValue)
            return Result.Failure<CheckOutOrderResponse>(PaymentError.InvalidOnlinePayment);

        #region Hangfire Jobs

        //var minusJobId = BackgroundJob.Schedule(() => MinusTransportQuantity(booking.PrivateTransportId), booking.Start);
        //JobRegistry.Register($"{nameof(MinusTransportQuantity).ToLower()}-{booking.Id}", minusJobId);

        //var plusJobId = BackgroundJob.Schedule(() => PlusTransportQuantity(booking.PrivateTransportId), booking.End.Value);
        //JobRegistry.Register($"{nameof(PlusTransportQuantity).ToLower()}-{booking.Id}", plusJobId);
        #endregion

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
        if (await _context.BookingPrivateTransports.FindAsync(bookingId) is not { } booking)
            return Result.Failure(BookingPrivateTransportError.NotFound);

        booking.PaymentDate = DateTime.UtcNow;
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

    public async Task<Result<BookingPrivateTransportResponse>> CreateAsync(string userId,
        BookingPrivateTransportRequest request)
    {
        var isExsist = await _context.PrivateTransports.AnyAsync(x => x.Id == request.PrivateTransportId);

        if (!isExsist)
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.NotFound);

        var isAvilable =
            await _context.PrivateTransports.AnyAsync(x => (x.Id == request.PrivateTransportId) && x.IsAvailable);

        if (!isAvilable)
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.NotAvilable);

        var booking = request.Adapt<BookingPrivateTransport>();

        var priceHour = await _context.PrivateTransports.Where(x => x.Id == request.PrivateTransportId)
            .Select(x => x.PricePerHour).FirstOrDefaultAsync();


        if (request.End.HasValue)
        {
            TimeSpan timeSpan = request.End.Value - request.Start;

            double totalHours = Math.Abs(timeSpan.TotalHours);

            booking.TotalPrice = totalHours * (double)priceHour;
        }
        else
        {
            var minusJobId =
                BackgroundJob.Schedule(() => MinusTransportQuantity(booking.PrivateTransportId), booking.Start);
            JobRegistry.Register($"{nameof(MinusTransportQuantity).ToLower()}-{booking.Id}", minusJobId);
        }

        booking.UserId = userId;

        await _context.BookingPrivateTransports.AddAsync(booking);
        await _context.SaveChangesAsync();

        var result = booking.Adapt<BookingPrivateTransportResponse>();

        result.PricePerHour = priceHour;

        return Result.Success(result);
    }

    public async Task<Result> UpdateAsync(int id, BookingPrivateTransportRequest request)
    {
        var booking = await _context.BookingPrivateTransports.FindAsync(id);

        if (booking is null)
            return Result.Failure<BookingPrivateTransportResponse>(BookingPrivateTransportError.NotFound);

        if (booking.PaymentDate.HasValue)
            return Result.Failure<BookingPrivateTransportResponse>(PaymentError.NotFound); // edit return //nassar done

        var pricePerHour = await _context.PrivateTransports
            .Where(x => x.Id == request.PrivateTransportId)
            .Select(x => x.PricePerHour)
            .FirstOrDefaultAsync();

        if (pricePerHour == default)
            return Result.Failure<PrivateTransportResponse>(PrivateTransportError.NotFound);

        booking = request.Adapt(booking);
        if (request.End.HasValue)
        {
            TimeSpan timeSpan = request.End.Value - request.Start;

            double totalHours = Math.Abs(timeSpan.TotalHours);

            booking.TotalPrice = totalHours * (double)pricePerHour;
        }


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


        booking.CancelBooking = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result<BookingPrivateTransportResponse>> EndBookingManualAsync(int id)
    {
        var booking = await _context.BookingPrivateTransports
            .Include(x => x.PrivateTransport)
            .ThenInclude(x=>x.TransportType)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (booking is null)
            return Result.Failure<BookingPrivateTransportResponse>(BookingPrivateTransportError.NotFound);

        if (booking.PaymentDate.HasValue)
            return Result.Failure<BookingPrivateTransportResponse>(PaymentError.AlreadyPeyment);

        if (booking.CancelBooking.HasValue)
            return Result.Failure<BookingPrivateTransportResponse>(PaymentError.AlreadyCancel);

        // manual payment
        if (booking.End.HasValue)
            return Result.Failure<BookingPrivateTransportResponse>(PaymentError.InvalidOnlinePayment);


        booking.End = DateTime.UtcNow;

        TimeSpan timeSpan = booking.End.Value - booking.Start;

        double totalHours = Math.Abs(timeSpan.TotalHours);

        booking.TotalPrice = Math.Round((totalHours * (double)booking.PrivateTransport.PricePerHour));


        var result = booking.Adapt<BookingPrivateTransportResponse>();
        result.TotalPrice = booking.TotalPrice;

        booking.PaymentDate = DateTime.UtcNow;
        booking.PrivateTransport.Quantity += 1;

        await _context.SaveChangesAsync();

        return Result.Success(result);
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
}

public static class JobRegistry
{
    private static readonly Dictionary<string, string> JobNameToId = new();

    public static void Register(string name, string jobId)
    {
        JobNameToId[name] = jobId;
    }

    public static string? GetJobId(string name)
    {
        return JobNameToId.TryGetValue(name, out var jobId) ? jobId : null;
    }

    public static void Remove(string name)
    {
        JobNameToId.Remove(name);
    }
}
