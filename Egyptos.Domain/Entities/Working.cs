namespace Egyptos.Domain.Entities;

public class Working
{
    public int Id { get; set; }
    public string Day { get; set; } = null!;
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public ICollection<AreaWorking> AreaWorkings { get; set; } = [];
}
