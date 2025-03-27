namespace Egyptos.Application.Contracts.Hotels;

public record HotelRequest(
     string Name,
     string Location,
     string Address,
     IFormFile ImageUrl,
     string WebSite,
     string Facebook,
     string PhoneNumber,
     double PricePerHour
);
