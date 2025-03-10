namespace Egyptos.Domain.Entities;

public class BookingTourGuide
{
    public int TourGuideId { get; set; }
    public TourGuide TourGuide { get; set; } = null!;

    public int TripId { get; set; }
    public Trip Trip { get; set; } = null!;

    public double TotalPrice { get; set; }

    public DateTime StartBooking { get; set; } = DateTime.UtcNow;
    public DateTime EndBooking { get; set; }
}
