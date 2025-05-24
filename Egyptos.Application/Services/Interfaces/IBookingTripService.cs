using Egyptos.Application.Contracts.BookingTrip;

namespace Egyptos.Application.Services.Interfaces;
public interface IBookingTripService
{
    Task<Result> BookATicket(string userId, BookingTripRequest request);
    Task<IEnumerable<BookingTripResponse>> GetAllAsync();
    Task<Result<IEnumerable<BookingTripResponse>>> BookedByUserAsync(string userId);
    Task<Result<IEnumerable<BookingTripResponse>>> TripBookedAsync(int tripId);
    Task<Result> DeleteAsync(int id);
}
