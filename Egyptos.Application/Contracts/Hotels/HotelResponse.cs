namespace Egyptos.Application.Contracts.Hotels;

public record HotelResponse(
      int Id,
     string Name,
     string Location,
     string Address,
     string ImageUrl,
     string WebSite,
     string Facebook,
     string PhoneNumber,
     double Rate,
     string LocationName,
     double PricePerHour

);
