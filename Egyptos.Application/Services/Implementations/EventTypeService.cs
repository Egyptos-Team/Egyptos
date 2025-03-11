using Egyptos.Application.Contracts.EventType;
using Egyptos.Application.Contracts.Roles;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Egyptos.Domain.Entities;

namespace Egyptos.Application.Services.Implementations;
public class EventTypeService(ApplicationDbContext context) : IEventTypeService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result> AddAsync(CreateEventTypeRequest request)
    {
        var isExstingType =await _context.EventTypes.AnyAsync(x => x.Name == request.Name);
        if(isExstingType)
            return Result.Failure(EventErrors.DuplicatedTypeName);

        var type = request.Adapt<EventType>();

        await _context.AddAsync(type);
        await _context.SaveChangesAsync();

        return Result.Success();
    }
    public async Task<IEnumerable<EventTypeResponse>> GetAllAsync()
        => await _context.EventTypes.AsNoTracking().ProjectToType<EventTypeResponse>().ToListAsync();
    public async Task<Result<EventTypeResponse>> GetAsync(int eventTypeId)
    {
        if(await _context.EventTypes.FindAsync(eventTypeId) is not { } eventType)
            return Result.Failure<EventTypeResponse>(EventErrors.EventTypeNotFount);

        return Result.Success(eventType.Adapt<EventTypeResponse>());
    }
    public async Task<Result<EventTypeResponse>> UpdateAsync(UpdateEventTypeRequest request)
    {
        if (await _context.EventTypes.FindAsync(request.Id) is not { } eventType)
            return Result.Failure<EventTypeResponse>(EventErrors.EventTypeNotFount);

        var isExistingType = 
            await _context.EventTypes.Where(x => x.Name == request.Name && x.Id != request.Id).AnyAsync();
        if (isExistingType)
            return Result.Failure<EventTypeResponse>(EventErrors.DuplicatedTypeName);

        eventType = request.Adapt(eventType);
        await _context.SaveChangesAsync();

        return Result.Success(eventType.Adapt<EventTypeResponse>());
    }
    public async Task<Result> DeleteAsync(int eventTypeId)
    {
        var isExstingType = await _context.EventTypes.AnyAsync(x => x.Id == eventTypeId);
        if (!isExstingType)
            return Result.Failure(EventErrors.EventTypeNotFount);

        _context.EventTypes.Remove(new EventType { Id = eventTypeId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}

