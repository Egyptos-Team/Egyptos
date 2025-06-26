using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.Payment;

namespace Egyptos.Application.Services.Interfaces;

public interface IBookingEventDateService
{
    Task<Result> BookATicket(string userId, int eventDateId);
    Task<IEnumerable<BookingEventDateRasponse>> GetAllAsync();
    Task<Result<BookingEventDateByUserRasponse>> BookedByUserAsync(string userId);
    Task<Result<BookingEventDateEventBooked>> EventBookedAsync(int eventDateId);
    Task<Result> DeleteAsync(string userId, int eventDateId);
    Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId, PaymentRequest paymentRequest);
    Task<Result> MarkAsPaidAsync(int bookingId);
}
