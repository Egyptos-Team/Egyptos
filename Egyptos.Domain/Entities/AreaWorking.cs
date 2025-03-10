namespace Egyptos.Domain.Entities;

public class AreaWorking
{
    public int AreaId { get; set; }
    public Area Area { get; set; } = null!;

    public int WorkingId { get; set; }
    public Working Working { get; set; } = null!;
}
