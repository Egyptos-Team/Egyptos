using Egyptos.Domain.Consts;
using Egyptos.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
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

        var passwordHasher = new PasswordHasher<ApplicationUser>();
        var hashedPassword = passwordHasher.HashPassword(null!, DefaultUser.AdminPassword);

        builder.HasData(new ApplicationUser
        {
            Id = DefaultUser.AdminId,
            FirstName = "Admin",
            LastName = "Admin",
            NationalId = "12345678901234",
            PhoneNumber = "1234567890",
            Sex = "Male",
            ImageUrl = "profiles/Default-Image.jpg",
            UserName = DefaultUser.AdminEmail,
            NormalizedUserName = DefaultUser.AdminEmail.ToUpper(),
            Email = DefaultUser.AdminEmail,
            NormalizedEmail = DefaultUser.AdminEmail.ToUpper(),
            SecurityStamp = DefaultUser.AdminSecurityStamp,
            ConcurrencyStamp = DefaultUser.AdminConcurrencyStamp,
            EmailConfirmed = true,
            PasswordHash = hashedPassword,
        });
    }
}
