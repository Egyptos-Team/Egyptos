namespace Egyptos.Application.Contracts.HistoricalImage;

public record HistoricalImageResponse
(
    int Id,
    int HistoricalId,
    string ImageUrl
);
