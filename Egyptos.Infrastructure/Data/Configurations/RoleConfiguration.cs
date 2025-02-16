using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData([
            new IdentityRole(){
                Id = DefaultRoles.Admin.Id,
                Name = DefaultRoles.Admin.Name,
                NormalizedName = DefaultRoles.Admin.Name.ToUpper(),
                ConcurrencyStamp = DefaultRoles.Admin.ConcurrencyStamp,
            },
            new IdentityRole(){
                Id = DefaultRoles.Employee.Id,
                Name = DefaultRoles.Employee.Name,
                NormalizedName = DefaultRoles.Employee.Name.ToUpper(),
                ConcurrencyStamp = DefaultRoles.Employee.ConcurrencyStamp,
            },
            new IdentityRole(){
                Id = DefaultRoles.TourGuide.Id,
                Name = DefaultRoles.TourGuide.Name,
                NormalizedName = DefaultRoles.TourGuide.Name.ToUpper(),
                ConcurrencyStamp = DefaultRoles.TourGuide.ConcurrencyStamp,
            },
            new IdentityRole(){
                Id = DefaultRoles.User.Id,
                Name = DefaultRoles.User.Name,
                NormalizedName = DefaultRoles.User.Name.ToUpper(),
                ConcurrencyStamp = DefaultRoles.User.ConcurrencyStamp,
            }
        ]);
    }
}
