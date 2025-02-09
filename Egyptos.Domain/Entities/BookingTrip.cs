using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class BookingTrip
{
    public int TripId { get; set; }
    public Trip Trip { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
