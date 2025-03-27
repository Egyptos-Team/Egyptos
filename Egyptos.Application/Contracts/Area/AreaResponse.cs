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
   //  List<Trip> Trips 
   List<AreaImagesResponse>  AreaImages
   //  List<AreaWorking> AreaWorkings 
   // List<Item> Items 
);
public record AreaImagesResponse(
    int Id,
    string Description,
    string ImageUrl
);