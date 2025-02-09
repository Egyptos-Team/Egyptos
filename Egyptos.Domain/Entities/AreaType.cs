namespace Egyptos.Domain.Entities;

public class AreaType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<Area> Areas { get; set; } = [];
}
