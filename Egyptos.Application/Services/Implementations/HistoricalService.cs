using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.Historical;
using Egyptos.Application.Services.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Egyptos.Application.Services.Implementations;

public class HistoricalService(ApplicationDbContext context, IFileService fileService) : IHistoricalService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<IEnumerable<HistoricalWithOutImageResponse>> GetAllAsync() => 
        await _context.Historicals
                .ProjectToType<HistoricalWithOutImageResponse>()
                .AsNoTracking()
                .ToListAsync();
    public async Task<Result<HistoricalResponse>> GetAsync(int HistoricalId)
    {
        var historical = await _context.Historicals
            .Where(x => x.Id == HistoricalId)
            .Include(x => x.HistoricalImages)
            .ProjectToType<HistoricalResponse>()
            .FirstOrDefaultAsync();

        if (historical is null)
            return Result.Failure<HistoricalResponse>(HistoricalErrors.HistoricalNotFount);

        return Result.Success(historical);
    }
    public async Task<Result<HistoricalResponse>> UpdateAsync(int HistoricalId, UpdateHistoricalRequest request)
    {
        if (await _context.Historicals.FindAsync(HistoricalId) is not { } historical)
            return Result.Failure<HistoricalResponse>(HistoricalErrors.HistoricalNotFount);

        historical = request.Adapt(historical);

        var currentImages = await _context.HistoricalImages
            .Where(x => x.HistoricalId == HistoricalId)
            .ToListAsync();

        var x2 = historical.HistoricalImages;

        foreach (var image in currentImages)
        {
            historical.HistoricalImages.Remove(image);
            await _fileService.DeleteAsync(image.ImageUrl);
        }

        foreach (var image in request.Images)
        {
            var imageUrl = await _fileService.UploadAsync(image, "Historical");
            historical.HistoricalImages.Add(new HistoricalImage { ImageUrl = imageUrl });
        }

        var imageUrl2 = await _fileService.UploadAsync(request.Image, "Historical");
        historical.ImageUrl = imageUrl2;

        await _context.SaveChangesAsync();

        return Result.Success(historical.Adapt<HistoricalResponse>());
    }
    public async Task<Result> DeleteAsync(int HistoricalId)
    {
        var isExstingHistorical = await _context.Historicals.AnyAsync(x => x.Id == HistoricalId);
        if (!isExstingHistorical)
            return Result.Failure(HistoricalErrors.HistoricalNotFount);

        var currentImages = await _context.HistoricalImages
            .Where(x => x.HistoricalId == HistoricalId)
            .ToListAsync();

        foreach (var image in currentImages)
        {
            await _fileService.DeleteAsync(image.ImageUrl);
        }

        _context.Historicals.Remove(new Historical { Id = HistoricalId });

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
