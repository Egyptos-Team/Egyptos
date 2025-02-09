namespace Egyptos.Domain.Entities;

public class TourGuideTrip
{
    public int TourGuideId { get; set; }
    public TourGuide TourGuide { get; set; } = null!;

    public int TripId { get; set; }
    public Trip Trip { get; set; } = null!;
}
