namespace Egyptos.Domain.Entities;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public int EventTypeId { get; set; }
    public EventType EventType { get; set; } = null!;

    public ICollection<EventDate> EventDates { get; set; } = [];
}
