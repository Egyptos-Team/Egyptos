using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bded8535075", "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3808b9cb-48b0-4a56-9492-67f362dfa9b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5694452c-4bfe-4bd0-a97e-57f5948684e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74f74d5a-25a8-456f-a703-7eb67721679e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "803d9ac6-8b8b-4e41-932f-8b0ef2bee591");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df4f87ce-beee-493f-a115-c2eb96babc7a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10eb7637-95f4-45d2-b200-84dbb188ec41", 0, "1ca42846-c687-48a2-9eb4-77fc5f21ae44", "Ramy@gmail.com", true, "Ramy", "profiles/16 Black Chefs Changing Food in America (Published 2019).jpeg", "Aziz", false, null, "30303409168364", "RAMY@GMAIL.COM", "RAMY@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "011298640281", false, "f439954d-63d4-4e36-8a5f-827f533cc6a1", "Male", false, "Ramy@gmail.com" },
                    { "249aa6c5-d578-4517-8a42-48f24a7d959e", 0, "e7ed49bc-72fb-42be-afc5-fbd0351bd759", "Khaled@gmail.com", true, "Khaled", "profiles/MEN - Location - Headshot Photography by Brandon Tabiolo.jpeg", "Mostafa", false, null, "30301920482846", "KHALED@GMAIL.COM", "KHALED@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01293749183", false, "f85433e6-bf5b-4ffc-9d02-3a7cc9938547", "Male", false, "Khaled@gmail.com" },
                    { "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1", 0, "d607b523-2920-4ea8-83c4-2103dbb45b0a", "Rola@gmail.com", true, "Rola", "profiles/Before and After_ Transforming Your LinkedIn Profile with AI Headshots.jpeg", "Samy", false, null, "30306183028747", "ROLA@GMAIL.COM", "ROLA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "012938475601", false, "eac93f1e-749b-4c66-9783-c46c16b4ffbf", "Female", false, "Rola@gmail.com" },
                    { "49a438ba-672d-41d5-97ba-5536ffbec2a6", 0, "f9773109-8364-4c61-a5d4-9fe85a58c0f4", "Kareem@gmail.com", true, "Kareem", "profiles/Why I Mainly Photograph in Portrait Orientation for Actors' Headshots.jpeg", "Maged", false, null, "303092689146845", "KAREEM@GMAIL.COM", "KAREEM@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01024860821", false, "aed0822d-8180-49b3-85cc-a4f5a33a3b56", "Male", false, "Kareem@gmail.com" },
                    { "52511e3a-0690-45b0-9e52-02667a473b18", 0, "e184b3aa-6771-4830-83f9-b1a59c9676c4", "Magdy@gmail.com", true, "Magdy", "profiles/Dallas Headshots Photographer - Willie & Kim Photography.jpeg", "Abdallah", false, null, "30301789256730", "MAGDY@GMAIL.COM", "MAGDY@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01183670178", false, "fda38b97-da47-40ba-bbe3-702a78f4e009", "Male", false, "Magdy@gmail.com" },
                    { "5d577849-97d1-4984-bf96-6fee7d08c8be", 0, "edb44c87-00c3-488a-9b74-2fc632b48bfc", "Marry@gmail.com", true, "Mary", "profiles/468f9794-778b-429f-bea8-b7440810819d.jpeg", "John", false, null, "40423109753269", "MARRY@GMAIL.COM", "MARRY@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "02029837399", false, "e27dc6f7-4bf0-44a1-a3fb-8b3e5239e87f", "Female", false, "Marry@gmail.com" },
                    { "683211b1-1125-42a1-b148-a606a4ca4df3", 0, "b3c8f4ef-c9ab-49b5-9b16-06f17aa7668a", "Ahmed12@gmail.com", true, "Ahmed", "profiles/df4fb389-64ed-486e-be7d-722771b6e3bc.jpeg", "Hesham", false, null, "30305521354688", "AHMED12@GMAIL.COM", "AHMED12@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01024866094", false, "46e17415-53e4-4e26-8ce4-3b9f91a4ebcd", "Male", false, "Ahmed12@gmail.com" },
                    { "6b9b3e85-ce32-4944-9a46-601bb2b40000", 0, "a61c81ae-cdb2-4c92-ae17-75247a4cb5cb", "Hassan44@gmail.com", true, "Hassan", "profiles/Friendly Professional Business Headshot.jpeg", "Alaa", false, null, "30306729061246", "HASSAN4412@GMAIL.COM", "HASSAN4412@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01079945073", false, "33fe0c4e-09d7-4b8b-a625-7cf0651fb90e", "Male", false, "Hassan44@gmail.com" },
                    { "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4", 0, "0a0bc059-4d5d-45dc-98dc-5e557d7aa1c1", "Maher@gmail.com", true, "Maher", "profiles/Rajan Velu.jpeg", "Mohamed", false, null, "30301937508274", "MAHER@GMAIL.COM", "MAHER@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01208173649", false, "04a9f78c-43b0-4a6f-bb40-c161adb30b23", "Male", false, "Maher@gmail.com" },
                    { "8766c317-1eaa-468a-b34d-59790c8eb915", 0, "c4986d9a-0ff6-4ecb-9f51-b8bb5dc826e4", "Rana@gmail.com", true, "Rana", "profiles/2edc3141-b4cd-411d-9136-33440bbb1c03.jpeg", "Osama", false, null, "30304597102873", "RANA@GMAIL.COM", "RANA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01028649032", false, "f5e74c9d-fe75-442e-a90e-6400f6a2f0c7", "Female", false, "Rana@gmail.com" },
                    { "a0e2f1e7-53e5-416f-b0b0-ca4668563233", 0, "a46ec364-f74a-455e-93f2-471913135d05", "Malek@gmail.com", true, "Malek", "profiles/9c12d50d-5cbe-4c75-8bca-cbc57d504a7b.jpeg", "Mohamed", false, null, "30308103829384", "MALEK@GMAIL.COM", "MALEK@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01283604718", false, "16dd3214-5abc-48b6-83cd-df00d21f16dc", "Male", false, "Malek@gmail.com" },
                    { "bf2ee728-59af-45ec-9b70-e5f5e27eef8e", 0, "43d7bf34-bc3a-4d7f-841e-f1dfd028303d", "Halem@gmail.com", true, "Halem", "profiles/Gorgeous smile of Alexis Petit.jpeg", "Ebrahim", false, null, "30308391092836", "HALEM@GMAIL.COM", "HALEM@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01049182640", false, "999faa1d-9041-4c56-888c-42b8286d68b7", "Male", false, "Halem@gmail.com" },
                    { "cb3cb7ca-1921-49fd-a11e-600b351b3df2", 0, "c76ae4f3-37a2-4707-b71b-f5d99f6f50da", "Salma@gmail.com", true, "Salma", "profiles/Women in Business.jpeg", "Mostafa", false, null, "30302901738376", "SALMA@GMAIL.COM", "SALMA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01029836539", false, "2121aa48-49d8-4b1e-841e-48a7e61b0863", "Female", false, "Salma@gmail.com" },
                    { "cb3cb7ca-1921-49fd-a11e-600b351b3df3", 0, "f58fbbd5-a0d4-460c-bc0d-5afb9a0adb63", "Jesseyd@gmail.com", true, "Jessy", "profiles/9151a7a4-4fc2-4bb0-a427-f97f4127e661.jpeg", "Danial", false, null, "40415678901625", "JESSEYD@GMAIL.COM", "JESSEYD@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "07022670816", false, "f4dd9dcd-8ef8-40fa-b1ac-6a6caa133079", "Female", false, "Jesseyd@gmail.com" },
                    { "cb3cb7ca-1921-49fd-a11e-600b351b3df4", 0, "f58fbbd5-a0d4-460c-bc0d-5afb9a0adb63", "Jessey@gmail.com", true, "Jessy", "profiles/9151a7a4-4fc2-4bb0-a427-f97f4127e661.jpeg", "MArk", false, null, "40415678901625", "JESSEY@GMAIL.COM", "JESSEY@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "07022670816", false, "f4dd9dcd-8ef8-40fa-b1ac-6a6caa133079", "Female", false, "Jessey@gmail.com" },
                    { "ce47a5ab-df14-416a-b500-9b544fa666a4", 0, "5d48db4f-16d7-418b-b97f-dbfe8616af56", "Nader@gmail.com", true, "Nader", "profiles/Mari Juliano.jpeg", "Ahmed", false, null, "303020837616543", "NADER@GMAIL.COM", "NADER@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01147893547", false, "e68c1657-3cb1-4097-a45f-27c1a655c81f", "Male", false, "Nader@gmail.com" },
                    { "df2ea217-2e82-48b9-9442-47556c1a9403", 0, "7e09e586-695e-44ad-86a9-f7b49ba3552b", "Ali@gmail.com", true, "Ali", "profiles/Outdoor Portraits — San Francisco Bay Area's Premier Personal Brand and Headshot Photographer _ Alpa.jpeg", "Salama", false, null, "30308795612367", "ALI@GMAIL.COM", "ALI@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01134409876", false, "287317a5-2b4e-4193-ade4-9b03c843b021", "Male", false, "Ali@gmail.com" },
                    { "f89bca4a-8fc9-4259-a46d-22562907c27f", 0, "c615d822-a4fc-4a3a-8b23-b4b6c155b96a", "Mark@gmail.com", true, "Mark", "profiles/44050f40-662d-408b-9dda-9e3271d7c36e.jpeg", "ALbrto", false, null, "4042098715635491", "MARK@GMAIL.COM", "MARK@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "070901468297", false, "6909260d-6430-4133-868e-9091e01fe56f", "Male", false, "Mark@gmail.com" },
                    { "fc4df06f-05c2-4751-96c1-8040f2761b7f", 0, "30d973bd-092f-4869-ac70-0b1004519b48", "Mohamed@gmail.com", true, "Mohamed", "profiles/82ebaf90-31fe-40ef-8358-99823ce3881d.jpeg", "Mady", false, null, "30309871265308", "MOHAMED@GMAIL.COM", "MOHAMED@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01084670325", false, "4a5413d0-0b02-48f8-a24f-16b929d0af74", "Male", false, "Mohamed@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10eb7637-95f4-45d2-b200-84dbb188ec41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "249aa6c5-d578-4517-8a42-48f24a7d959e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49a438ba-672d-41d5-97ba-5536ffbec2a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52511e3a-0690-45b0-9e52-02667a473b18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d577849-97d1-4984-bf96-6fee7d08c8be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "683211b1-1125-42a1-b148-a606a4ca4df3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b9b3e85-ce32-4944-9a46-601bb2b40000");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8766c317-1eaa-468a-b34d-59790c8eb915");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0e2f1e7-53e5-416f-b0b0-ca4668563233");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf2ee728-59af-45ec-9b70-e5f5e27eef8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb3cb7ca-1921-49fd-a11e-600b351b3df2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb3cb7ca-1921-49fd-a11e-600b351b3df3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb3cb7ca-1921-49fd-a11e-600b351b3df4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce47a5ab-df14-416a-b500-9b544fa666a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df2ea217-2e82-48b9-9442-47556c1a9403");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f89bca4a-8fc9-4259-a46d-22562907c27f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc4df06f-05c2-4751-96c1-8040f2761b7f");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0191d311-2918-7f76-bd8a-0bded8535075", "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3808b9cb-48b0-4a56-9492-67f362dfa9b4", 0, "56298673-8700-4929-8c4d-2a2983da53c2", "dfsfvvvv@gmail.com", true, "Amir", "profiles/Default-Image.jpg", "Mahmoud", false, null, "30303030303030", "DFSFVVVV@GMAIL.COM", "DFSFVVVV@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01010101010", false, "fb24b4fd-7658-4b81-82df-c853512f4627", "Male", false, "dfsfvvvv@gmail.com" },
                    { "5694452c-4bfe-4bd0-a97e-57f5948684e6", 0, "56304034-7947-436a-9f45-5aae19827221", "dfsfvvv@gmail.com", true, "Mohamed", "profiles/Default-Image.jpg", "Nassar", false, null, "30303030303030", "DFSFVVV@GMAIL.COM", "DFSFVVV@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01010101010", false, "47ab1ce3-1655-4215-bd95-af4642348d7c", "Male", false, "dfsfvvv@gmail.com" },
                    { "74f74d5a-25a8-456f-a703-7eb67721679e", 0, "90a57528-207c-4df0-9b83-bfac6cfe2d06", "dfsfv@gmail.com", true, "Ahmed", "profiles/Default-Image.jpg", "Hesham", false, null, "30303030303030", "DFSFV@GMAIL.COM", "DFSFV@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01010101010", false, "6c37c036-2659-4148-a23f-5d094da37121", "Male", false, "dfsfv@gmail.com" },
                    { "803d9ac6-8b8b-4e41-932f-8b0ef2bee591", 0, "ab5f9b96-4d25-4991-976c-dfd89da00178", "dfsfvvvvv@gmail.com", true, "Rafat", "profiles/Default-Image.jpg", "Ashrf", false, null, "30303030303030", "DFSFVVVVV@GMAIL.COM", "DFSFVVVVV@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01010101010", false, "15539178-b7a5-4270-a046-5cfaa7fbc3e8", "Male", false, "dfsfvvvvv@gmail.com" },
                    { "df4f87ce-beee-493f-a115-c2eb96babc7a", 0, "6921eade-b140-4d72-acec-4048194cc4a9", "dfsfvv@gmail.com", true, "Yousef", "profiles/Default-Image.jpg", "Mohamed", false, null, "30303030303030", "DFSFVV@GMAIL.COM", "DFSFVV@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01010101010", false, "cf3e134f-bd5a-41d1-a4e5-92cbe8da262e", "Male", false, "dfsfvv@gmail.com" }
                });
        }
    }
}
