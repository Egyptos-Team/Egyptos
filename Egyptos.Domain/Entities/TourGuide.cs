using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class TourGuide
{
    public int Id { get; set; }
    public double Salary { get; set; }
    public bool IsAvailable { get; set; }
    public bool IsActive { get; set; }

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;


    public ICollection<TourGuideTrip> TourGuideTrips { get; set; } = [];
}
