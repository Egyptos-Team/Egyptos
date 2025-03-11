using Azure.Core;
using Egyptos.Application.Contracts.Event;
using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

    //public async Task<IEnumerable<Event>> GetAllAsync() =>
    //    await _context.Events.AsNoTracking().ToListAsync();
}
