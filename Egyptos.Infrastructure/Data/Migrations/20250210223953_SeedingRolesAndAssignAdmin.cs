using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingRolesAndAssignAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0191d311-2918-7f76-bd8a-0bded8535075", "0191d311-2918-7f76-bd8a-0be08dd83078", "Admin", "ADMIN" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff8", "0191d311-2918-7f76-bd8a-0be100f11384", "User", "USER" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "B1F115C4-D298-4C6D-AA7B-6C7DC785A1C5", "TourGuide", "TOURGUIDE" },
                    { "ce2fd704-7a3c-4a03-846e-c5479a8b921d", "aacecacd-28e1-43cc-92da-decb1f9b32c4", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Egyptian" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NationalId", "NationalityId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66", 0, "123 Main St", "5c8298a9-982f-4d9d-a632-55f7d148f735", "admin@egyptos.com", true, "Admin", "profiles/admin.png", "Admin", false, null, "12345678901234", 1, "ADMIN@EGYPTOS.COM", "ADMIN@EGYPTOS.COM", "AQAAAAIAAYagAAAAECOh3m/xuKx23cnnBX7G5eoEiIPh/DMKdfQR/MOVtyN/UHKZ8O+I3gb/PZGWHwh+VQ==", "1234567890", false, "6f3a18b3-c453-4a3a-b2e3-57f2e0429f50", "Male", false, "admin@egyptos.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0191d311-2918-7f76-bd8a-0bded8535075", "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0191d311-2918-7f76-bd8a-0bdf740adff8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6CCF2454-C7FE-4F58-89FB-F565AE5643E3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce2fd704-7a3c-4a03-846e-c5479a8b921d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bded8535075", "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0191d311-2918-7f76-bd8a-0bded8535075");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66");

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
