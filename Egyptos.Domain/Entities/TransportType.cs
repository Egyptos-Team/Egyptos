namespace Egyptos.Domain.Entities;

public class TransportType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<PrivateTransport> PrivateTransports { get; set; } = [];
}
