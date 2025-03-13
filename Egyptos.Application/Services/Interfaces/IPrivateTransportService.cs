using Egyptos.Application.Contracts.Transport.PrivateTransports;
using Egyptos.Application.Contracts.Transport.TransportTypes;

namespace Egyptos.Application.Services.Interfaces;

public interface IPrivateTransportService
{
    Task<Result<List<PrivateTransportResponse>>> GetAllAsync();

   // Task<Result<List<PrivateTransportResponse>>> GetAllAvilableAsync();
    Task<Result<PrivateTransportResponse>> GetAsync(int id);
    Task<Result<PrivateTransportResponse>> CreateAsync(PrivateTransportRequest request);

    Task<Result> UpdateAsync(int id, PrivateTransportRequest request);
    Task<Result> DeleteAsync(int id);
}
