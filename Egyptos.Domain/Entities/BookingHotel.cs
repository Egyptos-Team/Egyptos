using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class BookingHotel
{
    public Hotel Hotel { get; set; } = null!;
    public int HotelId { get; set; }

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
