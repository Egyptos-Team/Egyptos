using Egyptos.Application.Contracts.BookingTrip;
using Egyptos.Domain.Entities;
using static Egyptos.Domain.Consts.DefaultRoles;

namespace Egyptos.Application.Services.Implementations;
internal class BookingTripService(ApplicationDbContext context) : IBookingTripService
{
    private readonly ApplicationDbContext _context = context;

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

}
