using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.EventImages;

public record CreateEventImageRequest
(
    IFormFile Image,
    int EventId
);