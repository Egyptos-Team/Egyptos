namespace Egyptos.Domain.Entities;

public class EventDate
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public DateTime StartSubscription { get; set; }
    public DateTime EndSubscription { get; set; }

    public bool IsActiveToSubscribe
    {
        get => DateTime.UtcNow <= EndSubscription && DateTime.UtcNow >= StartSubscription;
        set { }
    }

    public string Description { get; set; } = null!;
    public string Location { get; set; } = null!;

    public double Price { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; } = null!;

    public ICollection<EventImage> EventImages { get; set; } = [];
}
