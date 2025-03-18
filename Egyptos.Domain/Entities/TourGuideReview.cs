using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class TourGuideReview
{
    public int Id { get; set; }
    public string Comment { get; set; } = null!;
    public double Rate { get; set; }
    public DateOnly Date { get; set; }

    public int TourId { get; set; }
    public TourGuide TourGuide { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
