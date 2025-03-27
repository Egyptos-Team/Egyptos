using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.Area;

public record AreaRequest(
    string Name,
     string Description,
     string Location,
     string Address,
     string ImageUrl,
     int AreaTypeId,
     List<IFormFile> AreaImages
);
