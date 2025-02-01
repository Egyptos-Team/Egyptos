namespace Egyptos.Domain.Entities.Transports;

public class TransportType
{
    public int Id { get; set; }
    public string Type { get; set; } = null!;

    public ICollection<PrivateTransport> PrivateTransports { get; set; } = [];
    public ICollection<PublicTransport> PublicTransports { get; set; } = [];
}
