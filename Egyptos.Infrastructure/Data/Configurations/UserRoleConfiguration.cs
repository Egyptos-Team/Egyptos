using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        var userRole = new List<IdentityUserRole<string>>
        {
            new IdentityUserRole<string>
            {
                UserId = DefaultUser.AdminId,
                RoleId = DefaultRoles.Admin.Id
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "683211b1-1125-42a1-b148-a606a4ca4df3"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "df2ea217-2e82-48b9-9442-47556c1a9403"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "6b9b3e85-ce32-4944-9a46-601bb2b40000"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "fc4df06f-05c2-4751-96c1-8040f2761b7f"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "ce47a5ab-df14-416a-b500-9b544fa666a4"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "249aa6c5-d578-4517-8a42-48f24a7d959e"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "49a438ba-672d-41d5-97ba-5536ffbec2a6"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "bf2ee728-59af-45ec-9b70-e5f5e27eef8e"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df2"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df3"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "5d577849-97d1-4984-bf96-6fee7d08c8be"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "f89bca4a-8fc9-4259-a46d-22562907c27f"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df4"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "8766c317-1eaa-468a-b34d-59790c8eb915"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "52511e3a-0690-45b0-9e52-02667a473b18"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "a0e2f1e7-53e5-416f-b0b0-ca4668563233"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1"
            },
            new IdentityUserRole<string>
            {
                RoleId = DefaultRoles.TourGuide.Id,
                UserId = "10eb7637-95f4-45d2-b200-84dbb188ec41"
            }

        };
           
        builder.HasData(userRole);
    }
}
