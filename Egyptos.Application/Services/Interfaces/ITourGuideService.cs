using Egyptos.Application.Contracts.TourGuideReviews;

namespace Egyptos.Application.Services.Interfaces;

public interface ITourGuideService
{
    Task<List<TourGuideReviewResponse>> GetAllForTourGuide(int tourGuideId);
}
