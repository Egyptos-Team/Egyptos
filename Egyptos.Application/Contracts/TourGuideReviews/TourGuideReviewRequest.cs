namespace Egyptos.Application.Contracts.TourGuideReviews;

public class TourGuideReviewRequest
{
    public string Comment { get; set; } = null!;
    public IFormFile? Image { get; set; }
    public double Rate { get; set; }

    public int TourGuideId { get; set; }
}
