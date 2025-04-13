using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateInMuseumArea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 101,
                column: "ImageUrl",
                value: "AreaImages/01.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 103,
                column: "ImageUrl",
                value: "AreaImages/03.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 104,
                column: "ImageUrl",
                value: "AreaImages/04.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 108,
                column: "ImageUrl",
                value: "AreaImages/08.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 101,
                column: "ImageUrl",
                value: "AreaImages/01.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 103,
                column: "ImageUrl",
                value: "AreaImages/03.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 104,
                column: "ImageUrl",
                value: "AreaImages/04.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 108,
                column: "ImageUrl",
                value: "AreaImages/08.jpg");
        }
    }
}
