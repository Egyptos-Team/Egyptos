using Egyptos.Application.Contracts.BookingTrip;
using Egyptos.Application.Contracts.Payment;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Entities;
using Microsoft.Extensions.Configuration;
using static Egyptos.Domain.Consts.DefaultRoles;

namespace Egyptos.Application.Services.Implementations;
internal class BookingTripService(ApplicationDbContext context,IPayment payment,IConfiguration configuration) : IBookingTripService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IPayment _payment = payment;
    private readonly IConfiguration _configuration = configuration;

    public async Task<Result> BookATicket(string userId, BookingTripRequest request)
    {
        if (await _context.Trips.FindAsync(request.TripId) is not { } trip)
            return Result.Failure<BookingTripResponse>(BookingTripErrors.TripNotFount);

        if (trip.AvailableSeats < request.NumberOfTickets)
            return Result.Failure<BookingTripResponse>(BookingTripErrors.NotEnoughSeatsAvailable);

        var bookingTrip = new BookingTrip
        {
            TripId = request.TripId,
            UserId = userId,
            NumberOfTickets = request.NumberOfTickets,
            TotalPrice = trip.Price * request.NumberOfTickets
        };

        trip.AvailableSeats -= request.NumberOfTickets;
        _context.Trips.Update(trip);

        await _context.BookingTrips.AddAsync(bookingTrip);
        await _context.SaveChangesAsync();

        return Result.Success();
    }
    public async Task<IEnumerable<BookingTripResponse>> GetAllAsync() =>
           await _context.BookingTrips
                .Include(x => x.User)
                .Include(x => x.Trip)
                .ThenInclude(x => x.TripPrograms)
                .ProjectToType<BookingTripResponse>()
                .AsNoTracking()
                .ToListAsync();
    public async Task<Result<IEnumerable<BookingTripResponse>>> BookedByUserAsync(string userId)
    {
        var IsExistingUser = await _context.BookingTrips.AnyAsync(x => x.UserId == userId);
        if (!IsExistingUser)
            return Result.Failure<IEnumerable<BookingTripResponse>>(BookingTripErrors.UserNotBooked);


        var bookingTrip = await _context.BookingTrips
                .Where(x => x.UserId == userId)
                .Include(x => x.User)
                .Include(x => x.Trip)
                .ThenInclude(x => x.TripPrograms)
                .ProjectToType<BookingTripResponse>()
                .AsNoTracking()
                .ToListAsync();

        return Result.Success<IEnumerable<BookingTripResponse>>(bookingTrip);
    }
    public async Task<Result<IEnumerable<BookingTripResponse>>> TripBookedAsync(int tripId)
    {
        var IsExistingTrip = await _context.BookingTrips.AnyAsync(x => x.TripId == tripId);
        if (!IsExistingTrip)
            return Result.Failure<IEnumerable<BookingTripResponse>>(BookingTripErrors.TripNotBooked);


        var bookingTrip = await _context.BookingTrips
                 .Where(x => x.TripId == tripId)
                 .Include(x => x.User)
                 .Include(x => x.Trip)
                 .ThenInclude(x => x.TripPrograms)
                 .ProjectToType<BookingTripResponse>()
                 .AsNoTracking()
                 .ToListAsync();

        return Result.Success<IEnumerable<BookingTripResponse>>(bookingTrip);
    }
    public async Task<Result> DeleteAsync(int id)
    {
        if (await _context.BookingTrips.FindAsync(id) is not { } bookingTrip)
            return Result.Failure(BookingTripErrors.BookingNotFount);

        var trip = await _context.Trips.FindAsync(bookingTrip.TripId);

        trip!.AvailableSeats += bookingTrip.NumberOfTickets;
        _context.Trips.Update(trip);

        await _context.SaveChangesAsync();

        _context.BookingTrips.Remove(bookingTrip);
        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId, string userId, PaymentRequest paymentRequest)
    {
        var booking= await _context.BookingTrips
            .Include(t=>t.Trip)
            .ThenInclude(a=>a.Area)
            .ThenInclude(i=>i.AreaImages)
            .FirstOrDefaultAsync(x=>x.Id==bookingId&&x.UserId==userId);

        if (booking is null)
            return Result.Failure<CheckOutOrderResponse>(BookingTripErrors.BookingNotFount);

        if (booking.PaymentDate.HasValue)
            return Result.Failure<CheckOutOrderResponse>(PaymentError.AlreadyPeyment);

        var fullDescription = booking.Trip.Area.Description ?? "";
        var indexOfComma = fullDescription.IndexOf(',');

        var beforeComma = indexOfComma >= 0
            ? fullDescription.Substring(0, indexOfComma)
            : fullDescription; 

        booking.Trip.Area.Description = beforeComma;

        var sessionId = await _payment.ProcessPayment(booking, paymentRequest);

        var result = new CheckOutOrderResponse
        {
            SessionId = sessionId,
            PubKey = _configuration["Stripe:PubKey"]!
        };

        return Result.Success(result);
    }

    public async Task<Result> MarkAsPaidAsync(int bookingId, string userId)
    {
        if (await _context.BookingTrips.FirstOrDefaultAsync(x => x.Id == bookingId && x.UserId == userId) is not { } booking)
            return Result.Failure(EventErrors.BookingNotFount);

        booking.PaymentDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return Result.Success(booking);
    }
}
