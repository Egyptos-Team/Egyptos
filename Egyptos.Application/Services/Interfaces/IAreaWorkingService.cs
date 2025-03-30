using Egyptos.Application.Contracts.AreaWorking;

namespace Egyptos.Application.Services.Interfaces;
public interface IAreaWorkingService
{
    Task<Result<AreaWorkingResponse>> AddAsync(AreaWorkingRequest request);
    Task<ICollection<AreaWorkingResponse>> GetAllAsync();
    Task<Result> DeleteAsync(AreaWorkingRequest request);
}
