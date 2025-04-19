using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.BookingTourGuide;
using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.TourGuide;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Domain.Entities;
using Egyptos.Domain.Errors.PrivateTransport;
using Hangfire;
using static Egyptos.Domain.Consts.DefaultRoles;

namespace Egyptos.Application.Services.Implementations;

public class BookingTourGuideService(ApplicationDbContext context) : IBookingTourGuideService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<BookingTourGuideResponse>> BookATicketAsync(string userId, BookingTourGuideRequest request)
    {
        if (await _context.TourGuides.Include(x => x.User).FirstOrDefaultAsync(x => x.Id == request.TourGuideId) is not { } tourGuide)
            return Result.Failure<BookingTourGuideResponse>(TourGuideErrors.TourGuideNotFount);

        var isAvilable = await _context.TourGuides.AnyAsync(x => (x.Id == request.TourGuideId) && x.IsAvailable);

        if (!isAvilable)
            return Result.Failure<BookingTourGuideResponse>(TourGuideErrors.TourGuideNotAvilable);

        var booking = request.Adapt<BookingTourGuide>();

        var priceHour = await _context.TourGuides.Where(x => x.Id == request.TourGuideId).Select(x => x.SalaryPerHour).FirstOrDefaultAsync();

        TimeSpan timeSpan = request.EndBooking - request.StartBooking;
        double totalHours = Math.Abs(timeSpan.TotalHours);

        booking.TotalPrice = totalHours * (double)priceHour;
        booking.UserId = userId;

        tourGuide.Rate += 0.1;

        await _context.BookingTourGuides.AddAsync(booking);
        await _context.SaveChangesAsync();
        var Booking = booking.Adapt<BookingTourGuideResponse>();

        Booking.TourGuideFirstName = tourGuide.User.FirstName;
        Booking.TourGuideLastName = tourGuide.User.LastName;    

        return Result.Success(Booking);
    }
    public async Task<IEnumerable<BookingTourGuideResponse>> GetAllAsync() =>
           await _context.BookingTourGuides
                .Include(x => x.User)
                .Include(x=> x.TourGuide)
                .ProjectToType<BookingTourGuideResponse>()
                .AsNoTracking()
                .ToListAsync();
    public async Task<Result<List<BookingTourGuideResponse>>> BookedByUserAsync(string userId)
    {
        var IsExistingUser = await _context.BookingTourGuides.AnyAsync(x => x.UserId == userId);
        if (!IsExistingUser)
            return Result.Failure<List<BookingTourGuideResponse>>(TourGuideErrors.UserNotBooked);

        var bookingTourGuide = await _context.BookingTourGuides
                .Where(x => x.UserId == userId)
                .Include(x => x.User)
                .Include(x => x.TourGuide)
                .ProjectToType<BookingTourGuideResponse>()
                .AsNoTracking()
                .ToListAsync();

        return Result.Success(bookingTourGuide.Adapt<List<BookingTourGuideResponse>>());
    }
    public async Task<Result<List<BookingTourGuideResponse>>> TourGuideBookedAsync(int tourGuideId)
    {
        var IsExistingToureGuide = await _context.BookingTourGuides.AnyAsync(x => x.TourGuideId == tourGuideId);
        if (!IsExistingToureGuide)
            return Result.Failure<List<BookingTourGuideResponse>>(TourGuideErrors.TourGuideNotBooked);

        var bookingTourGuide = await _context.BookingTourGuides
                .Where(x => x.TourGuideId == tourGuideId)
                .Include(x => x.User)
                .Include(x => x.TourGuide)
                .ProjectToType<BookingTourGuideResponse>()
                .AsNoTracking()
                .ToListAsync();

        return Result.Success(bookingTourGuide.Adapt<List<BookingTourGuideResponse>>());
    }
    public async Task<Result<List<BookingTourGuideResponse>>> TourGuideBookedAsync(string userId)
    {
        if (await _context.TourGuides.Include(x => x.User).FirstOrDefaultAsync(x => x.UserId == userId) is not { } tourGuid)
            return Result.Failure<List<BookingTourGuideResponse>>(TourGuideErrors.TourGuideNotFount);

        var IsExistingToureGuide = await _context.BookingTourGuides.AnyAsync(x => x.TourGuideId == tourGuid.Id);
        if (!IsExistingToureGuide)
            return Result.Failure<List<BookingTourGuideResponse>>(TourGuideErrors.TourGuideNotBooked);

        var bookingTourGuide = await _context.BookingTourGuides
                .Where(x => x.TourGuideId == tourGuid.Id)
                .Include(x => x.User)
                .Include(x => x.TourGuide)
                .ProjectToType<BookingTourGuideResponse>()
                .AsNoTracking()
                .ToListAsync();


        return Result.Success(bookingTourGuide.Adapt<List<BookingTourGuideResponse>>());
    }

    public async Task<Result> DeleteAsync(int bookingId)
    {
        var booking = await _context.BookingTourGuides.FindAsync(bookingId);
        if (booking is null)
            return Result.Failure(TourGuideErrors.BookingNotFount);

        _context.Remove(booking);
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
