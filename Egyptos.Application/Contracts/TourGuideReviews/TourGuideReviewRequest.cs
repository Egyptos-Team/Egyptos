namespace Egyptos.Application.Contracts.TourGuideReviews;

public class TourGuideReviewRequest
{
    public string Comment { get; set; } = null!;
    public double Rate { get; set; }

    public int TourGuideId { get; set; }
}
