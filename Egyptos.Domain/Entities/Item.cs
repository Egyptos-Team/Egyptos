namespace Egyptos.Domain.Entities;

public class Item
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateOnly Date { get; set; }
    public string ImageUrl { get; set; } = null!;

    public int AreaId { get; set; }

    public Area Area{ get; set; }
}
