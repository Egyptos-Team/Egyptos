using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class BookingTourGuide
{
    public int TourGuideId { get; set; }
    public TourGuide TourGuide { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;

    public double TotalPrice { get; set; }

    public DateTime StartBooking { get; set; } = DateTime.UtcNow;
    public DateTime EndBooking { get; set; }
}
