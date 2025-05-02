namespace Egyptos.Application.Contracts.TripReview;
public class TripReviewResponse
{
    public int Id { get; set; }
    public string Comment { get; set; } 
    public string? ImageUrl { get; set; }
    public DateOnly Date { get; set; } 
    public double Rate { get; set; }
    public string TripName { get; set; }
    public string UserName { get; set; } 
}
