namespace Egyptos.Domain.Entities;

public class Area
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public double? Longitude { get; set; }
    public double? Latitude { get; set; }
    public int AreaTypeId { get; set; }
    public AreaType AreaType { get; set; } = null!;

    public ICollection<Trip> Trips { get; set; } = [];
    public ICollection<AreaImage> AreaImages { get; set; } = [];
    public ICollection<AreaWorking> AreaWorkings { get; set; } = [];
    public ICollection<Item> Items { get; set; } = [];
}
