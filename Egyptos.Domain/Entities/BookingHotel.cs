using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class BookingHotel
{
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;

    public DateTime CheckIn { get; set; } = DateTime.UtcNow;
    public DateTime CheckOut { get; set; }

    public double TotalPrice { get; set; }

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
