using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
