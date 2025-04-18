namespace Egyptos.Domain.Entities;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public double Rate { get; set; }
    public string LocationName { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string WebSite { get; set; } = null!;
    public string Facebook { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public double PricePerHour { get; set; }

    public double? Longitude { get; set; }
    public double? Latitude { get; set; }
    public ICollection<BookingHotel> BookingHotels { get; set; } = [];
}
