namespace Egyptos.Domain.Entities;

public class PrivateTransport
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public double PricePerHour { get; set; }

    public string Description { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public int Capacity { get; set; }

    public bool IsAvailable
    {
        get => Quantity > 0;
        set{}
    }

    public int Quantity { get; set; }

    public int TransportTypeId { get; set; }
    public TransportType TransportType { get; set; } = null!;

    public ICollection<BookingPrivateTransport> BookingPrivateTransports { get; set; } = [];
    public ICollection<PrivateTransportReview> PrivateTransportReviews { get; set; } = [];

}
