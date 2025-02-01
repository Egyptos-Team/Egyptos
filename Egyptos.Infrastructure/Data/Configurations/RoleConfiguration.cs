using Egyptos.Application.Abstractions.Consts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        /*builder.HasData([
            new IdentityRole(){
                Id = DefaultRoles.Admin.Id,
                Name = DefaultRoles.Admin.Name,
                NormalizedName = DefaultRoles.Admin.Name.ToUpper(),
                ConcurrencyStamp = DefaultRoles.Admin.ConcurrencyStamp,
            },

            new IdentityRole(){
                Id = DefaultRoles.Member.Id,
                Name = DefaultRoles.Member.Name,
                NormalizedName = DefaultRoles.Member.Name.ToUpper(),
                ConcurrencyStamp = DefaultRoles.Member.ConcurrencyStamp,
            }
        ]);*/
    }
}
