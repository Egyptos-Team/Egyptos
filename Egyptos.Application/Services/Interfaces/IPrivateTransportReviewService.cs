using Egyptos.Application.Contracts.PrivateTransportReview;

namespace Egyptos.Application.Services.Interfaces;
public interface IPrivateTransportReviewService
{
    Task<Result<PrivateTransportReviewResponse>> AddAsync(string userId, PrivateTransportReviewRequest request);
    Task<IEnumerable<PrivateTransportReviewResponse>> GetAllAsync();
    Task<IEnumerable<PrivateTransportReviewResponse>> GetAllForUserAsync(string userId);
    Task<Result<PrivateTransportReviewResponse>> UpdateAsync(string userId, int reviewId, PrivateTransportReviewRequest request);
    Task<Result> DeleteAsync(int reviewId);
}
