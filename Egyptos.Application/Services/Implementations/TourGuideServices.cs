using Egyptos.Application.Contracts.Event;
using Egyptos.Application.Contracts.TourGuide;
using TourGuide = Egyptos.Domain.Entities.TourGuide;

namespace Egyptos.Application.Services.Implementations;

public class TourGuideServices(ApplicationDbContext context, UserManager<ApplicationUser> _userManager) : ITourGuideServices
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<CreateTourGuideResponse>> AddAsync(CreateTourGuideRequest request)
    {
        //TODO incrumant years of exp every year by hangfire
        var isExstingUserId = await _context.ApplicationUsers.AnyAsync(x => x.Id == request.UserId);
        if (!isExstingUserId)
            return Result.Failure<CreateTourGuideResponse>(UserErrors.UserNotFound);

        var UserIdUsed = await _context.TourGuides.AnyAsync(x => x.UserId == request.UserId);
        if (UserIdUsed)
            return Result.Failure<CreateTourGuideResponse>(TourGuideErrors.DuplicatedUserId);

        var tourGuide = request.Adapt<TourGuide>();

        var user = await _userManager.FindByIdAsync(request.UserId);
        _userManager.AddToRoleAsync(user, "TourGuide").Wait();

        await _context.AddAsync(tourGuide);
        await _context.SaveChangesAsync();

        return Result.Success(tourGuide.Adapt<CreateTourGuideResponse>());
    }
    public async Task<IEnumerable<CustomTourGuideResponse>> GetAllAsync()
    {
        return await _context.TourGuides
        .Include(x => x.User)
        .ProjectToType<CustomTourGuideResponse>()
        .AsNoTracking()
        .ToListAsync();
    }
    public async Task<Result<TourGuideResponse>> GetAsync(int tourGuidId)
    {
        var tourGuide = await _context.TourGuides
            .Where(x => x.Id == tourGuidId)
            .Include(x=>x.TourGuideReviews)
            .Include(x => x.User)
            .Include(x => x.TourGuideTrips)
            .ProjectToType<TourGuideResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return tourGuide is null ? Result.Failure<TourGuideResponse>(TourGuideErrors.TourGuideNotFount) : Result.Success(tourGuide);
    }
    public async Task<Result<UpdateTourGuideResponse>> UpdateAsync(int tourGuidId, UpdateTourGuideRequest request)
    {
        if (await _context.TourGuides.FindAsync(tourGuidId) is not { } tourGuide)
            return Result.Failure<UpdateTourGuideResponse>(TourGuideErrors.TourGuideNotFount);

        tourGuide = request.Adapt(tourGuide);
        await _context.SaveChangesAsync();

        return Result.Success(tourGuide.Adapt<UpdateTourGuideResponse>());
    }
    public async Task<Result> DeleteAsync(int tourGuidId)
    {
        var isExstingTourGuide = await _context.TourGuides.AnyAsync(x => x.Id == tourGuidId);
        if (!isExstingTourGuide)
            return Result.Failure(TourGuideErrors.TourGuideNotFount);

        var userId = await _context.TourGuides
            .Where(x => x.Id == tourGuidId)
            .Select(x => x.UserId)
            .FirstAsync();

        var user = await _userManager.FindByIdAsync(userId);
        _userManager.RemoveFromRoleAsync(user, "TourGuide").Wait();

        _context.TourGuides.Remove(new TourGuide { Id = tourGuidId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
