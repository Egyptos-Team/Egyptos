using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAddressFromUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66",
                columns: new[] { "ImageUrl", "PasswordHash" },
                values: new object[] { "profiles/Default-Image.jpg", "AQAAAAIAAYagAAAAEB8koHSS3Qc5xDDyR9/sordYllKk8d8i/8jMvWdn3I7H040LOuksxNuQycqLuOtxeA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66",
                columns: new[] { "Address", "ImageUrl", "PasswordHash" },
                values: new object[] { "123 Main St", "profiles/admin.png", "AQAAAAIAAYagAAAAECOh3m/xuKx23cnnBX7G5eoEiIPh/DMKdfQR/MOVtyN/UHKZ8O+I3gb/PZGWHwh+VQ==" });
        }
    }
}
