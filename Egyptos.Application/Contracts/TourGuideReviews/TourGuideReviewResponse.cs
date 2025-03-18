namespace Egyptos.Application.Contracts.TourGuideReviews;

public class TourGuideReviewResponse
{
    public int Id { get; set; }
    public string Comment { get; set; } = null!;
    public double Rate { get; set; }
    public DateOnly Date { get; set; }



    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
