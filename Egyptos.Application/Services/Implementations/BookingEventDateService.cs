using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.EventDateContracts;
using Microsoft.Extensions.Logging;
using static Egyptos.Domain.Consts.DefaultRoles;

namespace Egyptos.Application.Services.Implementations;

public class BookingEventDateService(ApplicationDbContext context) : IBookingEventDateService
{
    private readonly ApplicationDbContext _context = context;

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
            UserId : userId,
            EventDates : await _context.BookingEventDates
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
            Users : await _context.BookingEventDates
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

        _context.BookingEventDates.Remove(new BookingEventDate { UserId = userId , EventDateId = eventDateId});
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
