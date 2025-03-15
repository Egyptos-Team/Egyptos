using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.BookingTourGuide;

namespace Egyptos.Application.Services.Interfaces;

public interface IBookingTourGuideService
{
    Task<Result> BookATicket(BookingTourGuideRequest request);
    //Task<IEnumerable<BookingEventDateRasponse>> GetAllAsync();
    //Task<Result<BookingEventDateByUserRasponse>> BookedByUserAsync(string userId);
    //Task<Result<BookingEventDateEventBooked>> EventBookedAsync(int eventDateId);
    //Task<Result> DeleteAsync(string userId, int eventDateId);
}
