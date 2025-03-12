using Egyptos.Application.Contracts.Transport.TransportTypes;


namespace Egyptos.Application.Services.Interfaces;

public interface ITransportTypeService
{
    Task<Result<TransportTypeResponse>> CreateAsync(TransportTypeRequest request, CancellationToken cancellationToken = default);
    Task<Result<TransportTypeResponse>> GetAsync(int id, CancellationToken cancellationToken = default);
}
