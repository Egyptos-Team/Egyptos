namespace Egyptos.Domain.Entities;

public class Area
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Location { get; set; } = null!;

    public int AreaTypeId { get; set; }
    public AreaType AreaType { get; set; } = null!;

    public ICollection<Trip> Trips { get; set; } = [];
    public ICollection<AreaImage> AreaImages { get; set; } = [];
}
