using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;
public class TripReview
{
    public int Id { get; set; }
    public string Comment { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public double Rate { get; set; }

    public int TripId { get; set; }
    public Trip Trip { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;


}
