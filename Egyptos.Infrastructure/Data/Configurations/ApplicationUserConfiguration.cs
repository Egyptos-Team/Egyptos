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

        //var passwordHasher = new PasswordHasher<ApplicationUser>();
        //var hashedPassword = passwordHasher.HashPassword(null!, DefaultUser.AdminPassword);

        builder.HasData
        (
            new ApplicationUser
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
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==",
            },
             new ApplicationUser
             {
                 Id = "74f74d5a-25a8-456f-a703-7eb67721679e",
                 FirstName = "Ahmed",
                 LastName = "Hesham",
                 NationalId = "30303030303030",
                 PhoneNumber = "01010101010",
                 Sex = "Male",
                 ImageUrl = "profiles/Default-Image.jpg",
                 UserName = "dfsfv@gmail.com",
                 NormalizedUserName = "DFSFV@GMAIL.COM",
                 Email = "dfsfv@gmail.com",
                 NormalizedEmail = "DFSFV@GMAIL.COM",
                 SecurityStamp = "6c37c036-2659-4148-a23f-5d094da37121",
                 ConcurrencyStamp = "90a57528-207c-4df0-9b83-bfac6cfe2d06",
                 EmailConfirmed = true,
                 PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==",
             },
             new ApplicationUser
             {
                 Id = "df4f87ce-beee-493f-a115-c2eb96babc7a",
                 FirstName = "Yousef",
                 LastName = "Mohamed",
                 NationalId = "30303030303030",
                 PhoneNumber = "01010101010",
                 Sex = "Male",
                 ImageUrl = "profiles/Default-Image.jpg",
                 UserName = "dfsfvv@gmail.com",
                 NormalizedUserName = "DFSFVV@GMAIL.COM",
                 Email = "dfsfvv@gmail.com",
                 NormalizedEmail = "DFSFVV@GMAIL.COM",
                 SecurityStamp = "cf3e134f-bd5a-41d1-a4e5-92cbe8da262e",
                 ConcurrencyStamp = "6921eade-b140-4d72-acec-4048194cc4a9",
                 EmailConfirmed = true,
                 PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==",
             },
             new ApplicationUser
             {
                 Id = "5694452c-4bfe-4bd0-a97e-57f5948684e6",
                 FirstName = "Mohamed",
                 LastName = "Nassar",
                 NationalId = "30303030303030",
                 PhoneNumber = "01010101010",
                 Sex = "Male",
                 ImageUrl = "profiles/Default-Image.jpg",
                 UserName = "dfsfvvv@gmail.com",
                 NormalizedUserName = "DFSFVVV@GMAIL.COM",
                 Email = "dfsfvvv@gmail.com",
                 NormalizedEmail = "DFSFVVV@GMAIL.COM",
                 SecurityStamp = "47ab1ce3-1655-4215-bd95-af4642348d7c",
                 ConcurrencyStamp = "56304034-7947-436a-9f45-5aae19827221",
                 EmailConfirmed = true,
                 PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==",
             },
             new ApplicationUser
             {
                 Id = "3808b9cb-48b0-4a56-9492-67f362dfa9b4",
                 FirstName = "Amir",
                 LastName = "Mahmoud",
                 NationalId = "30303030303030",
                 PhoneNumber = "01010101010",
                 Sex = "Male",
                 ImageUrl = "profiles/Default-Image.jpg",
                 UserName = "dfsfvvvv@gmail.com",
                 NormalizedUserName = "DFSFVVVV@GMAIL.COM",
                 Email = "dfsfvvvv@gmail.com",
                 NormalizedEmail = "DFSFVVVV@GMAIL.COM",
                 SecurityStamp = "fb24b4fd-7658-4b81-82df-c853512f4627",
                 ConcurrencyStamp = "56298673-8700-4929-8c4d-2a2983da53c2",
                 EmailConfirmed = true,
                 PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==",
             },
             new ApplicationUser
             {
                 Id = "803d9ac6-8b8b-4e41-932f-8b0ef2bee591",
                 FirstName = "Rafat",
                 LastName = "Ashrf",
                 NationalId = "30303030303030",
                 PhoneNumber = "01010101010",
                 Sex = "Male",
                 ImageUrl = "profiles/Default-Image.jpg",
                 UserName = "dfsfvvvvv@gmail.com",
                 NormalizedUserName = "DFSFVVVVV@GMAIL.COM",
                 Email = "dfsfvvvvv@gmail.com",
                 NormalizedEmail = "DFSFVVVVV@GMAIL.COM",
                 SecurityStamp = "15539178-b7a5-4270-a046-5cfaa7fbc3e8",
                 ConcurrencyStamp = "ab5f9b96-4d25-4991-976c-dfd89da00178",
                 EmailConfirmed = true,
                 PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==",
             }
        );
    }
}
