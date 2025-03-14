using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.Transport.PrivateTransports;

namespace Egyptos.Application.Services.Interfaces;

public interface IBookingPrivateTransportService
{
    //Task<Result<List<PrivateTransportResponse>>> GetAllAsync();

    // Task<Result<List<PrivateTransportResponse>>> GetAllAvilableAsync();
    Task<Result<BookingPrivateTransportResponse>> GetAsync(int id);
    Task<Result<BookingPrivateTransportResponse>> CreateAsync(string userId, BookingPrivateTransportRequest request);

    //Task<Result> UpdateAsync(int id, PrivateTransportRequest request);
    //Task<Result> DeleteAsync(int id);
}
