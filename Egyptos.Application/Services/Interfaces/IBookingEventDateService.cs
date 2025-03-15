using Egyptos.Application.Contracts.BookingEventDate;

namespace Egyptos.Application.Services.Interfaces;

public interface IBookingEventDateService
{
    Task<Result> BookATicket(string userId, int eventDateId);
    Task<IEnumerable<BookingEventDateRasponse>> GetAllAsync();
    Task<Result<BookingEventDateByUserRasponse>> BookedByUserAsync(string userId);
    Task<Result<BookingEventDateEventBooked>> EventBookedAsync(int eventDateId);
    Task<Result> DeleteAsync(string userId, int eventDateId);
}
