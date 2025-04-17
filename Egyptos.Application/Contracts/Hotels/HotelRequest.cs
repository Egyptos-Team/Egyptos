namespace Egyptos.Application.Contracts.Hotels;

public record HotelRequest(
     string Name,
     string Location,
     string LocationName,
     string Address,
     IFormFile ImageUrl,
     string WebSite,
     string Facebook,
     string PhoneNumber,
     double PricePerHour,
     double Rate,
     double? Longitude,
     double? Latitude
);
