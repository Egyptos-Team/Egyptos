using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.Transport.PrivateTransports;
using System.Threading.Tasks;
using Egyptos.Application.Contracts.Payment;

namespace Egyptos.Application.Services.Interfaces;

public interface IBookingPrivateTransportService
{
    Task<Result<List<BookingPrivateTransportResponse>>> GetAllAsync();
    Task<Result<List<BookingPrivateTransportResponse>>> GetAllForUserAsync(string userId);
    Task<Result<BookingPrivateTransportResponse>> GetAsync(int id);
    Task<Result<BookingPrivateTransportResponse>> CreateAsync(string userId, BookingPrivateTransportRequest request);
    Task<Result> UpdateAsync(int id, BookingPrivateTransportRequest request);
    Task<Result> MarkAsPaidAsync(int bookingId);

    Task<Result<CheckOutOrderResponse>> OnlinePaymentAsync(int bookingId,PaymentRequest request);
    Task<Result> CancelBookingAsync(int id);
    Task<Result<BookingPrivateTransportResponse>> EndBookingManualAsync(int id);
}
