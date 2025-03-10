namespace Egyptos.Domain.Entities;

public class HistoricalImage
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = null!;

    public int HistoricalId { get; set; }
    public Historical Historical { get; set; } = null!;
}
