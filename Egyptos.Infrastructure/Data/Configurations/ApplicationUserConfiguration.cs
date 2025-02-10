using Egyptos.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {

        builder.Property(x => x.FirstName).HasMaxLength(50);
        builder.Property(x => x.LastName).HasMaxLength(50);
        builder.Property(x => x.Sex).HasMaxLength(10);
        builder.Property(x => x.NationalId);
        builder.Property(x => x.Address).HasMaxLength(100);


        /*builder.HasData(new ApplicationUser()
        {
            Id = DefaultUser.AdminId,
            FirstName = "Admin",
            LastName = "Admin",
            UserName = DefaultUser.AdminEmail,
            NormalizedUserName = DefaultUser.AdminEmail.ToUpper(),
            Email = DefaultUser.AdminEmail,
            NormalizedEmail = DefaultUser.AdminEmail.ToUpper(),
            SecurityStamp = DefaultUser.AdminSecurityStamp,
            ConcurrencyStamp = DefaultUser.AdminConcurrencyStamp,
            EmailConfirmed = true,
            PasswordHash = DefaultUser.AdminPasswordHash
        });*/
    }
}
