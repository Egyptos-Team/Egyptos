using Egyptos.Application.Contracts.PrivateTransportReview;
using Egyptos.Domain.Errors.PrivateTransport;

namespace Egyptos.Application.Services.Implementations;
public class PrivateTransportReviewService(ApplicationDbContext context) : IPrivateTransportReviewService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<PrivateTransportReviewResponse>> AddAsync(string userId, PrivateTransportReviewRequest request)
    {
        if(!await _context.PrivateTransports.AnyAsync(x => x.Id == request.PrivateTransportId))
            return Result.Failure<PrivateTransportReviewResponse>(PrivateTransportError.NotFound);
                              
        var review = request.Adapt<PrivateTransportReview>();
        review.UserId = userId;
        await _context.PrivateTransportReviews.AddAsync(review);
        await _context.SaveChangesAsync();

        await _context.Entry(review).Reference(r => r.User).LoadAsync();
        await _context.Entry(review).Reference(r => r.PrivateTransport).LoadAsync();

        return Result.Success(review.Adapt<PrivateTransportReviewResponse>());
    }
    public async Task<IEnumerable<PrivateTransportReviewResponse>> GetAllAsync() =>
        await _context.PrivateTransportReviews
            .Include(x => x.PrivateTransport)
            .Include(x => x.User)
            .ProjectToType<PrivateTransportReviewResponse>()
            .AsNoTracking()
            .ToListAsync();
    public async Task<IEnumerable<PrivateTransportReviewResponse>> GetAllForUserAsync(string userId) =>
        await _context.PrivateTransportReviews
            .Include(x => x.PrivateTransport)
            .Include(x => x.User)
            .Where(x => x.UserId == userId)
            .ProjectToType<PrivateTransportReviewResponse>()
            .AsNoTracking()
            .ToListAsync();
    public async Task<Result<PrivateTransportReviewResponse>> UpdateAsync(string userId, int reviewId, PrivateTransportReviewRequest request)
    {
         var review = await _context.PrivateTransportReviews
            .Include(x => x.PrivateTransport)
            .Include(x => x.User)
            .FirstOrDefaultAsync(x => x.Id == reviewId);

         if (review is null)
             return Result.Failure<PrivateTransportReviewResponse>(PrivateTransportError.PrivateTransportReviewNotFount);

         if (!await _context.PrivateTransports.AnyAsync(x => x.Id == request.PrivateTransportId))
             return Result.Failure<PrivateTransportReviewResponse>(PrivateTransportError.NotFound);

         request.Adapt(review);
         review.UserId = userId;
         await _context.SaveChangesAsync();
         return Result.Success(review.Adapt<PrivateTransportReviewResponse>());
    }
    public async Task<Result> DeleteAsync(int reviewId)
    {
        var review = await _context.PrivateTransportReviews.FirstOrDefaultAsync(x => x.Id == reviewId);
        if (review is null)
            return Result.Failure(PrivateTransportError.PrivateTransportReviewNotFount);

        _context.PrivateTransportReviews.Remove(review);
        await _context.SaveChangesAsync();
        return Result.Success();
    }
}
