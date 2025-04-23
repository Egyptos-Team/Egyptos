namespace Egyptos.Domain.Entities;

public class Trip
{
    public int Id { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public DateTime BackTime { get; set; }
    public double Price { get; set; }
    public int AvailableSeats { get; set; }
    public bool IsActive { get => DateTime.UtcNow < DepartureTime && AvailableSeats > 0; set { } }

    public int PublicTransportId { get; set; }
    public PublicTransport PublicTransport { get; set; } = null!;

    public int AreaId { get; set; }
    public Area Area { get; set; } = null!;

    public ICollection<BookingTrip> BookingTrips { get; set; } = [];
    public ICollection<TourGuideTrip> TourGuideTrips { get; set; } = [];
}
