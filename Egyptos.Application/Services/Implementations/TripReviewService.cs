using Egyptos.Application.Contracts.TripReview;

namespace Egyptos.Application.Services.Implementations;
public class TripReviewService(ApplicationDbContext context, IFileService fileService) : ITripReviewService
{
    private readonly ApplicationDbContext _Context = context;
    private readonly IFileService _FileService = fileService;

   
  
    public async Task<IEnumerable<TripReviewResponse>> GetAllAsync()
    {
       var reviews=await _Context.TripReviews
            .Include(x=>x.User)
            .Include(a=>a.Trip)
            .AsNoTracking()
            .ProjectToType<TripReviewResponse>()
            .ToListAsync();

        return reviews;
    }

    public async Task<IEnumerable<TripReviewResponse>> GetAllForUserAsync(string userId)
    {
        var reviews= await _Context.TripReviews
            .Include(x=>x.Trip)
            .Include(x=>x.User)
            .Where(x => x.UserId == userId)
            .AsNoTracking()
            .ProjectToType<TripReviewResponse>()
            .ToListAsync();

        return reviews;
    }
    public async Task<Result<TripReviewResponse>> AddAsync(string userId, TripReviewRequest request)
    {
        if (!await _Context.Trips.AnyAsync(x => x.Id == request.TripId))
            return Result.Failure<TripReviewResponse>(TripReviewsError.TripNotFount);

        if (!await _Context.ApplicationUsers.AnyAsync(x => x.Id == userId))
            return Result.Failure<TripReviewResponse>(UserErrors.UserNotFound);

        var review = request.Adapt<TripReview>();
        review.UserId = userId;
        if ((request.ImageUrl is not null))
            review.ImageUrl = await _FileService.UploadAsync(request.ImageUrl!, "ReviewImages");
        await _Context.TripReviews.AddAsync(review);
        await _Context.SaveChangesAsync();

        await _Context.Entry(review).Reference(r => r.User).LoadAsync();
        await _Context.Entry(review).Reference(r => r.Trip).LoadAsync();
        await _Context.Entry(review.Trip).Reference(r => r.Area).LoadAsync();

        return Result.Success(review.Adapt<TripReviewResponse>());

    }


    public async Task<Result<TripReviewResponse>> UpdateAsync(string userId, int reviewId, TripReviewRequest request)
    {
        var review = await _Context.TripReviews.Include(x=>x.User).Include(x=>x.Trip.Area).FirstOrDefaultAsync(x => x.Id == reviewId);
        if (review is null)
            return Result.Failure<TripReviewResponse>(TripReviewsError.NotFount);

        if (!await _Context.Trips.AnyAsync(x => x.Id == request.TripId))
            return Result.Failure<TripReviewResponse>(TripReviewsError.TripNotFount);

        request.Adapt(review);
        review.UserId = userId;

        if ((request.ImageUrl is not null))
            review.ImageUrl = await _FileService.UploadAsync(request.ImageUrl!, "ReviewImages");

        await _Context.SaveChangesAsync();
        return Result.Success(review.Adapt<TripReviewResponse>());
        //return Result.Success(review.Adapt<TripReviewResponse>());

    }
    public async Task<Result> DeleteAsync(int reviewId)
    {
        var review = await _Context.TripReviews.FirstOrDefaultAsync(x => x.Id == reviewId);
        if (review is null)
            return Result.Failure(TripReviewsError.NotFount);

        _Context.TripReviews.Remove(review);
        await _Context.SaveChangesAsync();
        return Result.Success();
    }

}
