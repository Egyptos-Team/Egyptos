using Egyptos.Domain.Entities;

namespace Egyptos.Application.Contracts.Event;

public record EventResponse
(
    int Id,
    string Name,
    string Description,
    int EventTypeId,
    string EventTypeName,
    IEnumerable<EventDate> EventDates
);
