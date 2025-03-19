using Egyptos.Application.Contracts.TourGuideReviews;

namespace Egyptos.Application.Services.Interfaces;

public interface ITourGuideReviewService
{
    Task<IEnumerable<TourGuideReviewResponse>> GetAllAsync();
    Task<IEnumerable<TourGuideReviewResponse>> GetAllForUserAsync(string tourGuideId);
    Task<Result<TourGuideReviewResponse>> AddAsync(string userId, TourGuideReviewRequest request);
    Task<Result<TourGuideReviewResponse>> UpdateAsync(string userId, int review, TourGuideReviewRequest request);
    Task<Result> DeleteAsync(int reviewId);
}
