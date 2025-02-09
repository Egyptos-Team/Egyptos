namespace Egyptos.Domain.Entities;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string WebSite { get; set; } = null!;
    public string Facebook { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

    public ICollection<BookingHotel> BookingHotels { get; set; } = [];
}
