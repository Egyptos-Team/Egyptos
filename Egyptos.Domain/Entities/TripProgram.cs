namespace Egyptos.Domain.Entities;
public class TripProgram
{
    public int Id { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Destination { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int TripId { get; set; }
    public Trip Trip { get; set; } = null!;
}
