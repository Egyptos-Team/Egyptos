using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class BookingEventDate
{
    public int EventDateId { get; set; }
    public EventDate EventDate { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }
    public DateTime? CancelDate { get; set; }
}
