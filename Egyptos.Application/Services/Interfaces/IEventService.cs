using Egyptos.Application.Contracts.Event;
using Egyptos.Application.Contracts.EventType;
using Egyptos.Domain.Entities;

namespace Egyptos.Application.Services.Interfaces;

public interface IEventService
{
    Task<Result> AddAsync(CreateEventRequest request);
    //Task<IEnumerable<Event>> GetAllAsync();
    //Task<Result<EventTypeResponse>> GetAsync(int eventTypeId);
    //Task<Result<EventTypeResponse>> UpdateAsync(UpdateEventTypeRequest request);
    //Task<Result> DeleteAsync(int eventTypeId);
}
