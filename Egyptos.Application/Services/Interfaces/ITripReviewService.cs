using Egyptos.Application.Contracts.TripReview;

namespace Egyptos.Application.Services.Interfaces;
public interface ITripReviewService
{
    Task<IEnumerable<TripReviewResponse>> GetAllAsync();
    Task<IEnumerable<TripReviewResponse>> GetAllForUserAsync(string userId);
    Task<Result<TripReviewResponse>> AddAsync(string userId, TripReviewRequest request);
    Task<Result<TripReviewResponse>> UpdateAsync(string userId, int reviewId, TripReviewRequest request);
    Task<Result> DeleteAsync(int reviewId);
}
