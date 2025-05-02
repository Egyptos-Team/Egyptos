namespace Egyptos.Application.Contracts.TripReview;
public class TripReviewRequest
{
    public string Comment { get; set; } 
    public IFormFile? ImageUrl { get; set; }
    public double Rate { get; set; }
    public int TripId { get; set; }
}
