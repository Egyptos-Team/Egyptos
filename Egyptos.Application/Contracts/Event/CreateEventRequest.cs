namespace Egyptos.Application.Contracts.Event;

public record CreateEventRequest
(
    string Name,
    string Description,
    int EventTypeId
);