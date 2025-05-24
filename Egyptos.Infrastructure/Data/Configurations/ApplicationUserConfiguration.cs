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

        var Users = new List<ApplicationUser>()
        {
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
                Id = "683211b1-1125-42a1-b148-a606a4ca4df3",
                FirstName = "Ahmed",
                LastName = "Momamed",
                NationalId = "30305521354688",
                PhoneNumber = "01024866094",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Ahmed12@gmail.com",
                NormalizedEmail = "AHMED12@GMAIL.COM",
                UserName = "Ahmed12@gmail.com",
                NormalizedUserName = "AHMED12@GMAIL.COM",
                SecurityStamp = "46e17415-53e4-4e26-8ce4-3b9f91a4ebcd",
                ConcurrencyStamp = "b3c8f4ef-c9ab-49b5-9b16-06f17aa7668a",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "df2ea217-2e82-48b9-9442-47556c1a9403",
                FirstName = "Ali",
                LastName = "Salama",
                NationalId = "30308795612367",
                PhoneNumber = "01134409876",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Ali@gmail.com",
                NormalizedEmail = "ALI@GMAIL.COM",
                UserName = "Ali@gmail.com",
                NormalizedUserName = "ALI@GMAIL.COM",
                SecurityStamp = "287317a5-2b4e-4193-ade4-9b03c843b021",
                ConcurrencyStamp = "7e09e586-695e-44ad-86a9-f7b49ba3552b",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "6b9b3e85-ce32-4944-9a46-601bb2b40000",
                FirstName = "Hassan",
                LastName = "Alaa",
                NationalId = "30306729061246",
                PhoneNumber = "01079945073",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Hassan44@gmail.com",
                NormalizedEmail = "HASSAN4412@GMAIL.COM",
                UserName = "Hassan44@gmail.com",
                NormalizedUserName = "HASSAN4412@GMAIL.COM",
                SecurityStamp = "33fe0c4e-09d7-4b8b-a625-7cf0651fb90e",
                ConcurrencyStamp = "a61c81ae-cdb2-4c92-ae17-75247a4cb5cb",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "fc4df06f-05c2-4751-96c1-8040f2761b7f",
                FirstName = "Mohamed",
                LastName = "Mady",
                NationalId = "30309871265308",
                PhoneNumber = "01084670325",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Mohamed@gmail.com",
                NormalizedEmail = "MOHAMED@GMAIL.COM",
                UserName = "Mohamed@gmail.com",
                NormalizedUserName = "MOHAMED@GMAIL.COM",
                SecurityStamp = "4a5413d0-0b02-48f8-a24f-16b929d0af74",
                ConcurrencyStamp = "30d973bd-092f-4869-ac70-0b1004519b48",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4",
                FirstName = "Maher",
                LastName = "Mohamed",
                NationalId = "30301937508274",
                PhoneNumber = "01208173649",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Maher@gmail.com",
                NormalizedEmail = "MAHER@GMAIL.COM",
                UserName = "Maher@gmail.com",
                NormalizedUserName = "MAHER@GMAIL.COM",
                SecurityStamp = "04a9f78c-43b0-4a6f-bb40-c161adb30b23",
                ConcurrencyStamp = "0a0bc059-4d5d-45dc-98dc-5e557d7aa1c1",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "ce47a5ab-df14-416a-b500-9b544fa666a4",
                FirstName = "Nader",
                LastName = "Ahmed",
                NationalId = "303020837616543",
                PhoneNumber = "01147893547",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Nader@gmail.com",
                NormalizedEmail = "NADER@GMAIL.COM",
                UserName = "Nader@gmail.com",
                NormalizedUserName = "NADER@GMAIL.COM",
                SecurityStamp = "e68c1657-3cb1-4097-a45f-27c1a655c81f",
                ConcurrencyStamp = "5d48db4f-16d7-418b-b97f-dbfe8616af56",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "249aa6c5-d578-4517-8a42-48f24a7d959e",
                FirstName = "Khaled",
                LastName = "Mostafa",
                NationalId = "30301920482846",
                PhoneNumber = "01293749183",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Khaled@gmail.com",
                NormalizedEmail = "KHALED@GMAIL.COM",
                UserName = "Khaled@gmail.com",
                NormalizedUserName = "KHALED@GMAIL.COM",
                SecurityStamp = "f85433e6-bf5b-4ffc-9d02-3a7cc9938547",
                ConcurrencyStamp = "e7ed49bc-72fb-42be-afc5-fbd0351bd759",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "49a438ba-672d-41d5-97ba-5536ffbec2a6",
                FirstName = "Kareem",
                LastName = "Maged",
                NationalId = "303092689146845",
                PhoneNumber = "01024860821",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Kareem@gmail.com",
                NormalizedEmail = "KAREEM@GMAIL.COM",
                UserName = "Kareem@gmail.com",
                NormalizedUserName = "KAREEM@GMAIL.COM",
                SecurityStamp = "aed0822d-8180-49b3-85cc-a4f5a33a3b56",
                ConcurrencyStamp = "f9773109-8364-4c61-a5d4-9fe85a58c0f4",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "bf2ee728-59af-45ec-9b70-e5f5e27eef8e",
                FirstName = "Halem",
                LastName = "Ebrahim",
                NationalId = "30308391092836",
                PhoneNumber = "01049182640",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Halem@gmail.com",
                NormalizedEmail = "HALEM@GMAIL.COM",
                UserName = "Halem@gmail.com",
                NormalizedUserName = "HALEM@GMAIL.COM",
                SecurityStamp = "999faa1d-9041-4c56-888c-42b8286d68b7",
                ConcurrencyStamp = "43d7bf34-bc3a-4d7f-841e-f1dfd028303d",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "cb3cb7ca-1921-49fd-a11e-600b351b3df2",
                FirstName = "Salma",
                LastName = "Mostafa",
                NationalId = "30302901738376",
                PhoneNumber = "01029836539",
                Sex = "Female",
                ImageUrl = "profiles/22.jpg",
                Email = "Salma@gmail.com",
                NormalizedEmail = "SALMA@GMAIL.COM",
                UserName = "Salma@gmail.com",
                NormalizedUserName = "SALMA@GMAIL.COM",
                SecurityStamp = "2121aa48-49d8-4b1e-841e-48a7e61b0863",
                ConcurrencyStamp = "c76ae4f3-37a2-4707-b71b-f5d99f6f50da",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "cb3cb7ca-1921-49fd-a11e-600b351b3df3",
                FirstName = "Kosta",
                LastName = "Mohamed",
                NationalId = "40415678901625",
                PhoneNumber = "07022670816",
                Sex = "Female",
                ImageUrl = "profiles/22.jpg",
                Email = "Jesseyd@gmail.com",
                NormalizedEmail = "JESSEYD@GMAIL.COM",
                UserName = "Jesseyd@gmail.com",
                NormalizedUserName = "JESSEYD@GMAIL.COM",
                SecurityStamp = "f4dd9dcd-8ef8-40fa-b1ac-6a6caa133079",
                ConcurrencyStamp = "f58fbbd5-a0d4-460c-bc0d-5afb9a0adb63",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "5d577849-97d1-4984-bf96-6fee7d08c8be",
                FirstName = "Mary",
                LastName = "John",
                NationalId = "40423109753269",
                PhoneNumber = "02029837399",
                Sex = "Female",
                ImageUrl = "profiles/22.jpg",
                Email = "Marry@gmail.com",
                NormalizedEmail = "MARRY@GMAIL.COM",
                UserName = "Marry@gmail.com",
                NormalizedUserName = "MARRY@GMAIL.COM",
                SecurityStamp = "e27dc6f7-4bf0-44a1-a3fb-8b3e5239e87f",
                ConcurrencyStamp = "edb44c87-00c3-488a-9b74-2fc632b48bfc",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "f89bca4a-8fc9-4259-a46d-22562907c27f",
                FirstName = "Mark",
                LastName = "ALbrto",
                NationalId = "4042098715635491",
                PhoneNumber = "070901468297",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Mark@gmail.com",
                NormalizedEmail = "MARK@GMAIL.COM",
                UserName = "Mark@gmail.com",
                NormalizedUserName = "MARK@GMAIL.COM",
                SecurityStamp = "6909260d-6430-4133-868e-9091e01fe56f",
                ConcurrencyStamp = "c615d822-a4fc-4a3a-8b23-b4b6c155b96a",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "cb3cb7ca-1921-49fd-a11e-600b351b3df4",
                FirstName = "Jessy",
                LastName = "MArk",
                NationalId = "40415678901625",
                PhoneNumber = "07022670816",
                Sex = "Female",
                ImageUrl = "profiles/22.jpg",
                Email = "Jessey@gmail.com",
                NormalizedEmail = "JESSEY@GMAIL.COM",
                UserName = "Jessey@gmail.com",
                NormalizedUserName = "JESSEY@GMAIL.COM",
                SecurityStamp = "f4dd9dcd-8ef8-40fa-b1ac-6a6caa133079",
                ConcurrencyStamp = "f58fbbd5-a0d4-460c-bc0d-5afb9a0adb63",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="

            },
            new ApplicationUser
            {
                Id = "8766c317-1eaa-468a-b34d-59790c8eb915",
                FirstName = "Rana",
                LastName = "Osama",
                NationalId = "30304597102873",
                PhoneNumber = "01028649032",
                Sex = "Female",
                ImageUrl = "profiles/22.jpg",
                Email = "Rana@gmail.com",
                NormalizedEmail = "RANA@GMAIL.COM",
                UserName = "Rana@gmail.com",
                NormalizedUserName = "RANA@GMAIL.COM",
                SecurityStamp = "f5e74c9d-fe75-442e-a90e-6400f6a2f0c7",
                ConcurrencyStamp = "c4986d9a-0ff6-4ecb-9f51-b8bb5dc826e4",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "10eb7637-95f4-45d2-b200-84dbb188ec41",
                FirstName = "Ramy",
                LastName = "Aziz",
                NationalId = "30303409168364",
                PhoneNumber = "011298640281",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Ramy@gmail.com",
                NormalizedEmail = "RAMY@GMAIL.COM",
                UserName = "Ramy@gmail.com",
                NormalizedUserName = "RAMY@GMAIL.COM",
                SecurityStamp = "f439954d-63d4-4e36-8a5f-827f533cc6a1",
                ConcurrencyStamp = "1ca42846-c687-48a2-9eb4-77fc5f21ae44",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1",
                FirstName = "Rola",
                LastName = "Samy",
                NationalId = "30306183028747",
                PhoneNumber = "012938475601",
                Sex = "Female",
                ImageUrl = "profiles/22.jpg",
                Email = "Rola@gmail.com",
                NormalizedEmail = "ROLA@GMAIL.COM",
                UserName = "Rola@gmail.com",
                NormalizedUserName = "ROLA@GMAIL.COM",
                SecurityStamp = "eac93f1e-749b-4c66-9783-c46c16b4ffbf",
                ConcurrencyStamp = "d607b523-2920-4ea8-83c4-2103dbb45b0a",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "a0e2f1e7-53e5-416f-b0b0-ca4668563233",
                FirstName = "Malek",
                LastName = "Mohamed",
                NationalId = "30308103829384",
                PhoneNumber = "01283604718",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Malek@gmail.com",
                NormalizedEmail = "MALEK@GMAIL.COM",
                UserName = "Malek@gmail.com",
                NormalizedUserName = "MALEK@GMAIL.COM",
                SecurityStamp = "16dd3214-5abc-48b6-83cd-df00d21f16dc",
                ConcurrencyStamp = "a46ec364-f74a-455e-93f2-471913135d05",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            },
            new ApplicationUser
            {
                Id = "52511e3a-0690-45b0-9e52-02667a473b18",
                FirstName = "Magdy",
                LastName = "Abdallah",
                NationalId = "30301789256730",
                PhoneNumber = "01183670178",
                Sex = "Male",
                ImageUrl = "profiles/11.jpg",
                Email = "Magdy@gmail.com",
                NormalizedEmail = "MAGDY@GMAIL.COM",
                UserName = "Magdy@gmail.com",
                NormalizedUserName = "MAGDY@GMAIL.COM",
                SecurityStamp = "fda38b97-da47-40ba-bbe3-702a78f4e009",
                ConcurrencyStamp = "e184b3aa-6771-4830-83f9-b1a59c9676c4",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA=="
            }
        };

        builder.HasData(Users);
    }
}
