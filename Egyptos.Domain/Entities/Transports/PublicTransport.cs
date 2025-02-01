namespace Egyptos.Domain.Entities.Transports;

public class PublicTransport
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public string From { get; set; } = null!;
    public string To { get; set; } = null!;

    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }

    public string? ImageUrl { get; set; }

    public int Capacity { get; set; }
    public int NumberOfSeatsAvailable { get; set; }

    public double TripPrice { get; set; }

    public int TransportTypeId { get; set; }
    public TransportType TransportType { get; set; } = null!;

    public ICollection<BookingPublicTransport> BookingPublicTransports { get; set; } = [];
}
