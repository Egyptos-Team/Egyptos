using Egyptos.Application.Contracts.Working;

namespace Egyptos.Application.Services.Interfaces;
public interface IWorkingService
{
    Task<Result<WorkingResponse>> AddAsync(WorkingRequest request);
    Task<ICollection<WorkingResponse>> GetAllAsync();
    Task<Result<WorkingResponse>> GetAsync(int workingId);
    Task<Result<WorkingResponse>> UpdateAsync(int workingId, WorkingRequest request);
    Task<Result> DeleteAsync(int workingId);
}
