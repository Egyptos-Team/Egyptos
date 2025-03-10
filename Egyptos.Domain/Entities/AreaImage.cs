namespace Egyptos.Domain.Entities;

public class AreaImage
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string ImageUrl { get; set; } = null!;

    public int AreaId { get; set; }
    public Area Area { get; set; } = null!;
}
