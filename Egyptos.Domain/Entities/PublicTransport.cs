using System.ComponentModel.DataAnnotations.Schema;

namespace Egyptos.Domain.Entities;

public class PublicTransport
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Capacity { get; set; }
    public string ImageUrl { get; set; } = null!;

    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SerialNumber { get; set; }

    public int IsAvailable { get; set; }
}
