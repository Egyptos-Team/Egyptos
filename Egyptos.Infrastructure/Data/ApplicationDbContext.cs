using Egyptos.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Infrastructure.Data;

public class ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
