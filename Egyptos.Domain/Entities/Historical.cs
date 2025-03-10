namespace Egyptos.Domain.Entities;

public class Historical
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Date { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;

    public ICollection<HistoricalImage> HistoricalImages { get; set; } = [];
}
