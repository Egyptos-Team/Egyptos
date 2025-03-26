using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.EventType;

namespace Egyptos.Application.Contracts.Event;

public record EventResponse
(
    int Id,
    string Name,
    string Description,
    EventTypeResponse EventType,
    IEnumerable<EventDateResponse> EventDates
);
