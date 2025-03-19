using Egyptos.Application.Contracts.Event;
using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.EventImages;
using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static System.Net.Mime.MediaTypeNames;

namespace Egyptos.Application.Services.Implementations;

public class EventImageService(ApplicationDbContext context, IFileService fileService) : IEventImageService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<Result<EventImageResponse>> AddAsync(CreateEventImageRequest request)
    {
        if (await _context.Events.FindAsync(request.EventId) is not {})
            return Result.Failure<EventImageResponse>(EventErrors.EventNotFount);

        var eventImage = request.Adapt<EventImage>();

        eventImage.ImageUrl = await _fileService.UploadAsync(request.Image, "EventDates");

        await _context.AddAsync(eventImage);
        await _context.SaveChangesAsync();

        return Result.Success(eventImage.Adapt<EventImageResponse>());
    }
    public async Task<IEnumerable<EventImageResponse>> GetAllAsync() =>
        await _context.EventImages
            .ProjectToType<EventImageResponse>()
            .AsNoTracking()
            .ToListAsync();
    public async Task<Result<EventImageResponseV2>> GetAsync(int eventImageId)
    {
        var eventImage = await _context.EventImages
            .Where(x => x.Id == eventImageId)
            .ProjectToType<EventImageResponseV2>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (eventImage is null)
            return Result.Failure<EventImageResponseV2>(EventErrors.EventImageNotFount);

        return Result.Success(eventImage);
    }
    public async Task<Result> DeleteAsync(int eventImageId)
    {
        var isExstingEventImage = await _context.EventImages.AnyAsync(x => x.Id == eventImageId);
        if (!isExstingEventImage)
            return Result.Failure(EventErrors.EventImageNotFount);

        var image = await _context.EventImages.FindAsync(eventImageId);

        _context.EventImages.Remove(image!);
        await _fileService.DeleteAsync(image!.ImageUrl);

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
