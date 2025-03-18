using Egyptos.Application.Contracts.TourGuideReviews;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;

public class TourGuideService(ApplicationDbContext _context) : ITourGuideService
{
    public async Task<List<TourGuideReviewResponse>> GetAllForTourGuide(int tourGuideId)
    {
        var reviews = await _context.TourGuideReviews.Include(x => x.TourGuide).ToListAsync();

        return reviews.Adapt<List<TourGuideReviewResponse>>();
    }
}
