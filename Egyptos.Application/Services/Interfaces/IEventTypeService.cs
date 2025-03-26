using Egyptos.Application.Contracts.EventType;

namespace Egyptos.Application.Services.Interfaces;
public interface IEventTypeService
{
    Task<Result<EventTypeResponse>> AddAsync(CreateEventTypeRequest request);
    Task<IEnumerable<EventTypeResponse>> GetAllAsync();
    Task<Result<EventTypeResponse>> GetAsync(int eventTypeId);
    Task<Result<EventTypeResponse>> UpdateAsync(int id, UpdateEventTypeRequest request);
    Task<Result> DeleteAsync(int eventTypeId);
}

