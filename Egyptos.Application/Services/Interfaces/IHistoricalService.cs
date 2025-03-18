using Egyptos.Application.Contracts.Historical;

namespace Egyptos.Application.Services.Interfaces;

public interface IHistoricalService
{
    Task<IEnumerable<HistoricalWithOutImageResponse>> GetAllAsync();
    Task<Result<HistoricalResponse>> GetAsync(int HistoricalId);
    Task<Result<HistoricalResponse>> UpdateAsync(int HistoricalId, UpdateHistoricalRequest request);
    Task<Result> DeleteAsync(int HistoricalId);
}
