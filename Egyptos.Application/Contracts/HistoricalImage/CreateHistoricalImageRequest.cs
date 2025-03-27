namespace Egyptos.Application.Contracts.HistoricalImage;

public record CreateHistoricalImageRequest
(
    int HistoricalId,
    IFormFile Image
);