using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.BookingTourGuide;

namespace Egyptos.Application.Services.Interfaces;

public interface IBookingTourGuideService
{
    Task<Result<BookingTourGuideResponse>> BookATicketAsync(string userId, BookingTourGuideRequest request);
    Task<IEnumerable<BookingTourGuideResponse>> GetAllAsync();
    Task<Result<BookingTourGuideByUserRasponse>> BookedByUserAsync(string userId);
    Task<Result<BookingTourGuideBooked>> TourGuideBookedAsync(int tourGuideId);
    Task<Result<BookingTourGuideBooked>> TourGuideBookedAsync(string userId);
    Task<Result> DeleteAsync(string userId, int tourGuideId);
}
