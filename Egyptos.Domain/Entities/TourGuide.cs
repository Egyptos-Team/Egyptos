using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class TourGuide
{
    public int Id { get; set; }
    public double SalaryPerHour { get; set; }
    public string Description { get; set; } = null!;
    public int YearsOfExperience { get; set; }
    public double Rate { get; set; }
    public bool IsAvailable { get; set; }
    public bool IsActive { get; set; }

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;


    public ICollection<TourGuideTrip> TourGuideTrips { get; set; } = [];
}
