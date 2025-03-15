using Egyptos.Application.Contracts.TourGuide;

namespace Egyptos.Application.Services.Interfaces;

public interface ITourGuideServices
{
    Task<Result<CreateTourGuideResponse>> AddAsync(CreateTourGuideRequest request);
    Task<IEnumerable<TourGuideResponse>> GetAllAsync();
    Task<Result<TourGuideResponse>> GetAsync(int tourGuidId);
    Task<Result<UpdateTourGuideResponse>> UpdateAsync(int tourGuidId, UpdateTourGuideRequest request);
    Task<Result> DeleteAsync(int tourGuidId);
}
