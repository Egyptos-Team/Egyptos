namespace Egyptos.Application.Contracts.Event;

public record CreateEventResponse
(
    int Id,
    string Name,
    string Description,
    int EventTypeId
);