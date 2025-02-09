namespace Egyptos.Domain.Entities;

public class AreaImage
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;

    public int AreaId { get; set; }
    public Area Area { get; set; } = null!;
}
