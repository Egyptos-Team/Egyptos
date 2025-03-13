using Egyptos.Application.Contracts.Event;

namespace Egyptos.Application.Services.Interfaces;

public interface IEventService
{
    Task<Result<CreateEventResponse>> AddAsync(CreateEventRequest request);
    Task<IEnumerable<EventResponse>> GetAllAsync();
    Task<Result<EventResponse>> GetAsync(int eventId);
    Task<Result<UpdateEventResponse>> UpdateAsync(int eventId, UpdateEventRequest request);
    Task<Result> DeleteAsync(int eventId);
}
