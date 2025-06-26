using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.BookingTourGuide;
using Egyptos.Application.Contracts.Payment;

namespace Egyptos.Application.Services.Interfaces;

public interface IBookingTourGuideService
{
    Task<Result<BookingTourGuideResponse>> BookATicketAsync(string userId, BookingTourGuideRequest request);
    Task<IEnumerable<BookingTourGuideResponse>> GetAllAsync();
    Task<Result<List<BookingTourGuideResponse>>> BookedByUserAsync(string userId);
    Task<Result<List<BookingTourGuideResponse>>> TourGuideBookedAsync(int tourGuideId);
    Task<Result<List<BookingTourGuideResponse>>> TourGuideBookedAsync(string userId);
    Task<Result> DeleteAsync(string userId, int bookingId);
    Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId, PaymentRequest paymentRequest);
    Task<Result> MarkAsPaidAsync(int bookingId);
}
