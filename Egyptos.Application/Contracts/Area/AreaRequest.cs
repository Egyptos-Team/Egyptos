using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.Area;

public record AreaRequest(
    string Name,
     string Description,
     string Location,
     string Address,
     IFormFile ImageUrl,
     double? Latitude,
     double? Longitude,
     int AreaTypeId,
     List<IFormFile> AreaImages
);
