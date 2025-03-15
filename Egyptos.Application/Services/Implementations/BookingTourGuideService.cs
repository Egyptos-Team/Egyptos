using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.BookingTourGuide;
using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.TourGuide;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Domain.Entities;
using Egyptos.Domain.Errors.PrivateTransport;
using Hangfire;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;

public class BookingTourGuideService(ApplicationDbContext context) : IBookingTourGuideService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result> BookATicketAsync(string userId, BookingTourGuideRequest request)
    {
        if (await _context.TourGuides.FindAsync(request.TourGuideId) is not { } tourGuide)
            return Result.Failure(TourGuideErrors.TourGuideNotFount);

        var isAvilable = await _context.TourGuides.AnyAsync(x => (x.Id == request.TourGuideId) && x.IsAvailable);

        if (!isAvilable)
            return Result.Failure(TourGuideErrors.TourGuideNotAvilable);

        var booking = request.Adapt<BookingTourGuide>();

        var priceHour = await _context.TourGuides.Where(x => x.Id == request.TourGuideId).Select(x => x.SalaryPerHour).FirstOrDefaultAsync();

        TimeSpan timeSpan = request.EndBooking - request.StartBooking;
        double totalHours = Math.Abs(timeSpan.TotalHours);

        booking.TotalPrice = totalHours * (double)priceHour;
        booking.UserId = userId;

        await _context.BookingTourGuides.AddAsync(booking);
        await _context.SaveChangesAsync();

        return Result.Success();
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
            TourGuides : await _context.BookingTourGuides
                .Where(x => x.UserId == userId)
                .Include(x => x.TourGuide)
                .ThenInclude(x => x.User)
                .Select(x => x.TourGuide)
                .ProjectToType<TourGuideResponse>()
                .AsNoTracking()
                .ToListAsync()
        );

        return Result.Success(bookingTourGuide);
    }
    public async Task<Result<BookingTourGuideBooked>> TourGuideBookedAsync(int tourGuideId)
    {
        var IsExistingEventDate = await _context.BookingTourGuides.AnyAsync(x => x.TourGuideId == tourGuideId);
        if (!IsExistingEventDate)
            return Result.Failure<BookingTourGuideBooked>(TourGuideErrors.TourGuideNotBooked);


        var bookingTourGuide = new BookingTourGuideBooked
        (
            ToureGuidId: tourGuideId,
            Users: await _context.BookingTourGuides
                .Where(x => x.TourGuideId == tourGuideId)
                .Include(x => x.User)
                .Select(x => x.User)
                .ProjectToType<AuthResponse>()
                .AsNoTracking()
                .ToListAsync()
        );

        return Result.Success(bookingTourGuide);
    }
    public async Task<Result> DeleteAsync(string userId, int tourGuideId)
    {
        var isExstingBookinTourGuide = await _context.BookingTourGuides
            .AnyAsync(x => x.TourGuideId == tourGuideId && x.UserId == userId);

        if (!isExstingBookinTourGuide)
            return Result.Failure(TourGuideErrors.BookingNotFount);

        _context.BookingTourGuides.Remove(new BookingTourGuide { UserId = userId, TourGuideId = tourGuideId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
