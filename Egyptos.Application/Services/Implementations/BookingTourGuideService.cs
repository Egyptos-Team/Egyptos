using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.BookingTourGuide;
using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.TourGuide;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Domain.Entities;
using Egyptos.Domain.Errors.PrivateTransport;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using static Egyptos.Domain.Consts.DefaultRoles;

namespace Egyptos.Application.Services.Implementations;

public class BookingTourGuideService(ApplicationDbContext context) : IBookingTourGuideService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<BookingTourGuideResponse>> BookATicketAsync(string userId, BookingTourGuideRequest request)
    {
        if (await _context.TourGuides.FindAsync(request.TourGuideId) is not { } tourGuide)
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

        return Result.Success(booking.Adapt<BookingTourGuideResponse>());
    }
    public async Task<IEnumerable<BookingTourGuideResponse>> GetAllAsync() =>
           await _context.BookingTourGuides
                .ProjectToType<BookingTourGuideResponse>()
                .AsNoTracking()
                .ToListAsync();
    public async Task<Result<BookingTourGuideByUserRasponse>> BookedByUserAsync(string userId)
    {
        var IsExistingUser = await _context.BookingTourGuides.AnyAsync(x => x.UserId == userId);
        if (!IsExistingUser)
            return Result.Failure<BookingTourGuideByUserRasponse>(TourGuideErrors.UserNotBooked);

        var bookingTourGuide = new BookingTourGuideByUserRasponse
        (
            UserId: userId,
            AllBookeingForThisUser: await _context.BookingTourGuides
                .Where(x => x.UserId == userId)
                .Include(x => x.TourGuide)
                .Select(q => new { q.TotalPrice, BookingId = q.Id, q.StartBooking, q.EndBooking, q.TourGuide, q.TourGuide.User.FirstName, q.TourGuide.User.LastName, q.TourGuide.User.Email })
                .ProjectToType<BookingTourGuideWithoutUserIdResponse>()
                .AsNoTracking()
                .ToListAsync()
        );

        return Result.Success(bookingTourGuide);
    }
    public async Task<Result<BookingTourGuideBookedRasponse>> TourGuideBookedAsync(int tourGuideId)
    {
        var IsExistingToureGuide = await _context.BookingTourGuides.AnyAsync(x => x.TourGuideId == tourGuideId);
        if (!IsExistingToureGuide)
            return Result.Failure<BookingTourGuideBookedRasponse>(TourGuideErrors.TourGuideNotBooked);


        var bookingTourGuide = new BookingTourGuideBookedRasponse
        (
            TourGuideId: tourGuideId,
            BookingUsers: await _context.BookingTourGuides
                .Where(x => x.TourGuideId == tourGuideId)
                .Include(x => x.User)
                .ProjectToType<BookingTourGuideResponse>()
                .AsNoTracking()
                .ToListAsync()
        );

        return Result.Success(bookingTourGuide);
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

    public async Task<Result<BookingTourGuideBookedRasponse>> TourGuideBookedAsync(string userId)
    {
        if (await _context.TourGuides.FirstOrDefaultAsync(x => x.UserId == userId) is not { } tourGuid)
            return Result.Failure<BookingTourGuideBookedRasponse>(TourGuideErrors.TourGuideNotFount);

        var IsExistingToureGuide = await _context.BookingTourGuides.AnyAsync(x => x.TourGuideId == tourGuid.Id);
        if (!IsExistingToureGuide)
            return Result.Failure<BookingTourGuideBookedRasponse>(TourGuideErrors.TourGuideNotBooked);


        var bookingTourGuide = new BookingTourGuideBookedRasponse
        (
            TourGuideId: tourGuid.Id,
            BookingUsers: await _context.BookingTourGuides
                .Where(x => x.TourGuideId == tourGuid.Id)
                .Include(x => x.User)
                .ProjectToType<BookingTourGuideResponse>()
                .AsNoTracking()
                .ToListAsync()
        );

        return Result.Success(bookingTourGuide);
    }
}
