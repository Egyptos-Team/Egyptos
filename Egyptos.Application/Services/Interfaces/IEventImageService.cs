using Egyptos.Application.Contracts.EventImages;

namespace Egyptos.Application.Services.Interfaces;

public interface IEventImageService
{
    Task<Result<EventImageResponse>> AddAsync(CreateEventImageRequest request);
    Task<IEnumerable<EventImageResponse>> GetAllAsync();
    Task<Result<EventImageResponseV2>> GetAsync(int eventImageId);
    Task<Result> DeleteAsync(int eventImageId);
}
