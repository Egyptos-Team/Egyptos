namespace Egyptos.Application.Contracts.Historical;

public record HistoricalWithOutImageResponse
(
    int Id,
    string Title,
    string Description,
    string Date,
    string ImageUrl
);
