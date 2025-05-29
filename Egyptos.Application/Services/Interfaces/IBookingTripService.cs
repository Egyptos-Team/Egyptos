using Egyptos.Application.Contracts.BookingTrip;
using Egyptos.Application.Contracts.Payment;

namespace Egyptos.Application.Services.Interfaces;
public interface IBookingTripService
{
    Task<Result> BookATicket(string userId, BookingTripRequest request);
    Task<IEnumerable<BookingTripResponse>> GetAllAsync();
    Task<Result<IEnumerable<BookingTripResponse>>> BookedByUserAsync(string userId);
    Task<Result<IEnumerable<BookingTripResponse>>> TripBookedAsync(int tripId);
    Task<Result> DeleteAsync(int id);
    Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId, string userId, PaymentRequest paymentRequest);
    Task<Result> MarkAsPaidAsync(int bookingId, string userId);
}
