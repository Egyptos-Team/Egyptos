using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class Nationality
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<ApplicationUser> Users { get; set; } = [];
}
