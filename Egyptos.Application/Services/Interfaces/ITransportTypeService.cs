using Egyptos.Application.Contracts.Transport.TransportTypes;


namespace Egyptos.Application.Services.Interfaces;

public interface ITransportTypeService
{
    Task<Result<List<TransportTypeResponse>>> GetAllAsync();
    Task<Result<TransportTypeResponseWithTransports>> GetAsync(int id);
    Task<Result<TransportTypeResponse>> CreateAsync(TransportTypeRequest request);
    Task<Result> UpdateAsync(int id, TransportTypeRequest request);
    Task<Result> DeleteAsync(int id);


}
