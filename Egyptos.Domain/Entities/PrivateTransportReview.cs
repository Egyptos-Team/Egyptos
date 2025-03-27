using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;
public class PrivateTransportReview
{
    public int Id { get; set; }
    public string Comment { get; set; } = null!;
    public double Rate { get; set; }
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public int PrivateTransportId { get; set; }
    public PrivateTransport PrivateTransport { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
