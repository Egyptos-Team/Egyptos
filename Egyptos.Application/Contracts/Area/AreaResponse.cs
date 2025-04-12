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
   string ImageUrl ,
   int  AreaTypeId ,
   List<AreaImagesResponse> AreaImages,
   List<WorkingResponse> Working

);
public record AreaImagesResponse(
    int Id,
    string Description,
    string ImageUrl
);