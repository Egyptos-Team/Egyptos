using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Domain.Entities;

namespace Egyptos.Application.Services.Interfaces;

public interface IEventDateService
{
    Task<Result<EventDateResponse>> AddAsync(CreateEventDateRequest request);
    Task<IEnumerable<EventDateResponse>> GetAllAsync();
    Task<Result<EventDateResponse>> GetAsync(int eventDataId);
    Task<Result<EventDateResponse>> UpdateAsync(int eventDateId, UpdateEventDateRequest request);
    Task<Result> DeleteAsync(int eventDataId);
}
