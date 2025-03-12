using Azure.Core;
using Egyptos.Application.Contracts.Event;
using Egyptos.Application.Contracts.EventType;
using Egyptos.Application.Contracts.Users;
using Egyptos.Domain.Consts;
using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;


namespace Egyptos.Application.Services.Implementations;

public class EventService(ApplicationDbContext context) : IEventService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result> AddAsync(CreateEventRequest request)
    {
        var isExstingName = await _context.Events.AnyAsync(x => x.Name == request.Name);
        if(isExstingName)
            return Result.Failure(EventErrors.DuplicatedEventName);

       if(await _context.EventTypes.AnyAsync(x => x.Id == request.EventTypeId) == false)
            return Result.Failure(EventErrors.EventTypeNotFount);

        var event1 = request.Adapt<Event>();

        await _context.AddAsync(event1);
        await _context.SaveChangesAsync();

        return Result.Success();
    }
    public async Task<IEnumerable<EventResponse>> GetAllAsync()
    {
        var events = await _context.Events
            .Include(x => x.EventType)
            .Include(x => x.EventDates)
            .ProjectToType<EventResponse>()
            .AsNoTracking()
            .ToListAsync();

        #region Another way to get the data
        //var events = await (
        //                        from e in _context.Events
        //                        join et in _context.EventTypes
        //                        on e.EventTypeId equals et.Id into EET
        //                        join ed in _context.EventDates
        //                        on e.Id equals ed.EventId into EED
        //                        select (new 
        //                        {
        //                            e.Id,
        //                            e.Name,
        //                            e.Description,
        //                            e.EventTypeId,
        //                            EventTypeName = EET.FirstOrDefault().Name,
        //                            EventDates = EED.ToList()
        //                        })
        //                    )
        //                    .Select(u => new EventResponse
        //                        (
        //                             u.Id,
        //                             u.Name,
        //                             u.Description,
        //                             u.EventTypeId,
        //                             u.EventTypeName,
        //                             u.EventDates
        //                        )
        //                    )
        //                    .ToListAsync();
        #endregion

        return events;
    }
    public async Task<Result<EventResponse>> GetAsync(int eventId)
    {
        var @event = await _context.Events
            .Where(x => x.Id == eventId)
            .Include(x => x.EventType)
            .Include(x => x.EventDates)
            .ProjectToType<EventResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (@event is null)
            return Result.Failure<EventResponse>(EventErrors.EventNotFount);

        return Result.Success(@event);
    }
    public async Task<Result<UpdateEventResponse>> UpdateAsync(int evenId,UpdateEventRequest request)
    {
        if (await _context.Events.FindAsync(evenId) is not { } @event)
            return Result.Failure<UpdateEventResponse>(EventErrors.EventNotFount);

        var isExstingName = await _context.Events.AnyAsync(x => x.Name == request.Name && x.Id != evenId);
        if (isExstingName)
            return Result.Failure<UpdateEventResponse>(EventErrors.DuplicatedEventName);

        @event = request.Adapt(@event);
        await _context.SaveChangesAsync();

        return Result.Success(@event.Adapt<UpdateEventResponse>());
    }
    public async Task<Result> DeleteAsync(int eventId)
    {
        var isExstingEvent = await _context.Events.AnyAsync(x => x.Id == eventId);
        if (!isExstingEvent)
            return Result.Failure(EventErrors.EventNotFount);

        _context.Events.Remove(new Event { Id = eventId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
