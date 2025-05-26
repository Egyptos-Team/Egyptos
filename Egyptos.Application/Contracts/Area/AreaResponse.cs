using Egyptos.Application.Contracts.AreaWorking;
using Egyptos.Application.Contracts.Working;
using Egyptos.Domain.Entities;

namespace Egyptos.Application.Contracts.Area;

public record AreaResponse
(
   int Id ,
   string Name ,
   string Description ,
   string Location ,
   string Address ,
   string? AppAddress ,
   string ImageUrl ,
   int  AreaTypeId ,
   double? Latitude,
   double? Longitude,
   List<AreaImagesResponse> AreaImages,
   List<WorkingResponse> Working

);
public record AreaImagesResponse(
    int Id,
    string Description,
    string ImageUrl
);