using Egyptos.Application.Contracts.HistoricalImage;
using Egyptos.Domain.Entities;

namespace Egyptos.Application.Contracts.Historical;

public record HistoricalResponse
(
    int Id,
    string Title,
    string Description,
    string Date,
    string ImageUrl,
    IEnumerable<HistoricalImageResponse> HistoricalImages
);
