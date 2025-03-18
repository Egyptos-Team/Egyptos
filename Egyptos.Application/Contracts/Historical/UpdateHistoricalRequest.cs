using Egyptos.Application.Contracts.HistoricalImage;
using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.Historical;

public record UpdateHistoricalRequest
(
    string Title,
    string Description,
    string Date,
    IFormFile Image,
    List<IFormFile> Images
);
