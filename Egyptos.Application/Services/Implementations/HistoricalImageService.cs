using Egyptos.Application.Contracts.EventImages;
using Egyptos.Application.Contracts.HistoricalImage;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;
public class HistoricalImageService(ApplicationDbContext context, IFileService fileService) : IHistoricalImageService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<Result<HistoricalImageResponse>> AddAsync(CreateHistoricalImageRequest request)
    {
        if (await _context.Historicals.FindAsync(request.HistoricalId) is not { })
            return Result.Failure<HistoricalImageResponse>(HistoricalErrors.HistoricalNotFount);

        var historicalImage = request.Adapt<HistoricalImage>();

        historicalImage.ImageUrl = await _fileService.UploadAsync(request.Image, "Historical");

        await _context.AddAsync(historicalImage);
        await _context.SaveChangesAsync();

        return Result.Success(historicalImage.Adapt<HistoricalImageResponse>());
    }
    public async Task<IEnumerable<HistoricalImageResponse>> GetAllAsync() =>
        await _context.HistoricalImages
            .ProjectToType<HistoricalImageResponse>()
            .AsNoTracking()
            .ToListAsync();
    public async Task<Result<HistoricalImageResponse>> GetAsync(int historicalImageId)
    {
        var historicalImage = await _context.HistoricalImages
            .Where(x => x.Id == historicalImageId)
            .ProjectToType<HistoricalImageResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (historicalImage is null)
            return Result.Failure<HistoricalImageResponse>(HistoricalErrors.HistoricalImageNotFount);

        return Result.Success(historicalImage);
    }
    public async Task<Result> DeleteAsync(int historicalImageId)
    {
        var isExstingHistoricalImage = await _context.HistoricalImages.AnyAsync(x => x.Id == historicalImageId);
        if (!isExstingHistoricalImage)
            return Result.Failure(HistoricalErrors.HistoricalImageNotFount);

        var image = await _context.HistoricalImages.FindAsync(historicalImageId);

        _context.HistoricalImages.Remove(image!);
        await _fileService.DeleteAsync(image!.ImageUrl);

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
