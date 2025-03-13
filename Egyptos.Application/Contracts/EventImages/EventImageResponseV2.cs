namespace Egyptos.Application.Contracts.EventImages;

public record EventImageResponseV2
(
    int Id,
    int EventId,
    string ImageUrl
);
