using Egyptos.Application.Contracts.TourGuideReviews;
using Egyptos.Domain.Entities;

namespace Egyptos.Application.Services.Implementations;

public class TourGuideReviewService(ApplicationDbContext _context, IFileService fileService) : ITourGuideReviewService
{
    private readonly IFileService _fileService = fileService;

    public async Task<IEnumerable<TourGuideReviewResponse>> GetAllAsync()
    {
        var reviews = await _context.TourGuideReviews
            .Include(x => x.TourGuide)
            .ThenInclude(x => x.User)
            .Include(x => x.User)
            .ToListAsync();

        return reviews.Adapt<List<TourGuideReviewResponse>>();
    }

    public async Task<IEnumerable<TourGuideReviewResponse>> GetAllForUserAsync(string userId)
    {
        var reviews = await _context.TourGuideReviews
            .Include(x => x.TourGuide)
            .ThenInclude(x => x.User)
            .Include(x => x.User)
            .Where(x => x.UserId == userId)
            .ToListAsync();

        return reviews.Adapt<List<TourGuideReviewResponse>>();
    }


    public async Task<Result<TourGuideReviewResponse>> AddAsync(string userId, TourGuideReviewRequest request)
    {

        if (!await _context.TourGuides.AnyAsync(x => x.Id == request.TourGuideId))
            return Result.Failure<TourGuideReviewResponse>(TourGuideErrors.TourGuideNotFount);

        var review = request.Adapt<TourGuideReview>();

        review.UserId = userId;
        if((request.Image is not null))
        review.ImageUrl = await _fileService.UploadAsync(request.Image!, "ReviewImages");
        await _context.TourGuideReviews.AddAsync(review);
        await _context.SaveChangesAsync();

        await _context.Entry(review).Reference(r => r.User).LoadAsync();
        await _context.Entry(review).Reference(r => r.TourGuide).LoadAsync();
        await _context.Entry(review.TourGuide).Reference(tg => tg.User).LoadAsync();
        return Result.Success(review.Adapt<TourGuideReviewResponse>());
    }

    public async Task<Result<TourGuideReviewResponse>> UpdateAsync(string userId, int reviewId, TourGuideReviewRequest request)
    {
        var review = await _context.TourGuideReviews
            .Include(x => x.TourGuide)
            .ThenInclude(x => x.User)
            .Include(x => x.User)
            .FirstOrDefaultAsync(x => x.Id == reviewId);

        if (review is null)
            return Result.Failure<TourGuideReviewResponse>(TourGuideReviewErrors.TourGuideReviewNotFount);

        if (!await _context.TourGuides.AnyAsync(x => x.Id == request.TourGuideId))
            return Result.Failure<TourGuideReviewResponse>(TourGuideErrors.TourGuideNotFount);

        request.Adapt(review);
        review.UserId = userId;
        if ((request.Image is not null))
            review.ImageUrl = await _fileService.UploadAsync(request.Image!, "ReviewImages");
        else review.ImageUrl = null;

        await _context.SaveChangesAsync();
        return Result.Success(review.Adapt<TourGuideReviewResponse>());
    }

    public async Task<Result> DeleteAsync(int reviewId)
    {
        var review = await _context.TourGuideReviews.FirstOrDefaultAsync(x => x.Id == reviewId);
        if (review is null)
            return Result.Failure(TourGuideReviewErrors.TourGuideReviewNotFount);

        _context.TourGuideReviews.Remove(review);
        await _context.SaveChangesAsync();
        return Result.Success();
    }
}
