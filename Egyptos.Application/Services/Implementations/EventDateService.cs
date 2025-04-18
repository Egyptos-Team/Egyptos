using Egyptos.Application.Contracts.EventDateContracts;

namespace Egyptos.Application.Services.Implementations;

public class EventDateService(ApplicationDbContext context, IFileService fileService) : IEventDateService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<Result<EventDateResponse>> AddAsync(CreateEventDateRequest request)
    {
        if (await _context.Events.FindAsync(request.EventId) is not { } @event)
            return Result.Failure<EventDateResponse>(EventErrors.EventNotFount);

        if (request.Images.Count == 0)
            return Result.Failure<EventDateResponse>(EventErrors.ImageIsRequire);

        var eventDate = request.Adapt<EventDate>();


        foreach (var image in request.Images)
        {
            var imageUrl = await _fileService.UploadAsync(image, "EventDates");
            eventDate.EventImages.Add(new EventImage { ImageUrl = imageUrl });
        }

        await _context.AddAsync(eventDate);
        await _context.SaveChangesAsync();

        return Result.Success(eventDate.Adapt<EventDateResponse>());
    }
    public async Task<IEnumerable<EventDateResponse>> GetAllAsync()
    {
        var eventDate = await _context.EventDates
            .Include(x => x.EventImages)
            .ProjectToType<EventDateResponse>()
            .AsNoTracking()
            .ToListAsync();

        return eventDate;
    }
    public async Task<Result<EventDateResponse>> GetAsync(int eventDataId)
    {
        var eventData = await _context.EventDates
            .Where(x => x.Id == eventDataId)
            .Include(x => x.EventImages)
            .ProjectToType<EventDateResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (eventData is null)
            return Result.Failure<EventDateResponse>(EventErrors.EventDateNotFount);

        return Result.Success(eventData);
    }
    public async Task<Result<EventDateResponse>> UpdateAsync(int eventDateId, UpdateEventDateRequest request)
    {
        if (await _context.EventDates.FindAsync(eventDateId) is not { } eventDate)
            return Result.Failure<EventDateResponse>(EventErrors.EventDateNotFount);
        
        eventDate = request.Adapt(eventDate);

        var currentImages = await _context.EventImages
            .Where(x => x.EventId == eventDateId)            
            .ToListAsync();

        foreach (var image in currentImages)
        {
            eventDate.EventImages.Remove(image);
            await _fileService.DeleteAsync(image.ImageUrl);
        }

        foreach (var image in request.Images)
        {
            var imageUrl = await _fileService.UploadAsync(image, "EventDates");
            eventDate.EventImages.Add(new EventImage { ImageUrl = imageUrl });
        }


        await _context.SaveChangesAsync();

        return Result.Success(eventDate.Adapt<EventDateResponse>());
    }
    public async Task<Result> DeleteAsync(int eventDateId)
    {
        var isExstingEventData = await _context.EventDates.AnyAsync(x => x.Id == eventDateId);
        if (!isExstingEventData)
            return Result.Failure(EventErrors.EventDateNotFount);

        var currentImages = await _context.EventImages
            .Where(x => x.EventId == eventDateId)
            .ToListAsync();

        foreach (var image in currentImages)
        {
            await _fileService.DeleteAsync(image.ImageUrl);
        }

        _context.EventDates.Remove(new EventDate { Id = eventDateId });

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
