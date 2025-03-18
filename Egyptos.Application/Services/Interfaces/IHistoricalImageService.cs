using Egyptos.Application.Contracts.EventImages;
using Egyptos.Application.Contracts.HistoricalImage;

namespace Egyptos.Application.Services.Interfaces;

public interface IHistoricalImageService
{
    Task<Result<HistoricalImageResponse>> AddAsync(CreateHistoricalImageRequest request);
    Task<IEnumerable<HistoricalImageResponse>> GetAllAsync();
    Task<Result<HistoricalImageResponse>> GetAsync(int historicalImageId);
    Task<Result> DeleteAsync(int historicalImageId);
}
