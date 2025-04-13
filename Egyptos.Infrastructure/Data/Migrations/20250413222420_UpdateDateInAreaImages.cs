using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateInAreaImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "AreaImages/AA1.avif");

            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "AreaImages/AA2.jpg");

            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "AreaImages/AA3.jpeg");

            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "ImageUrl",
                value: "AreaImages/AA4.jpeg");

            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 491,
                column: "ImageUrl",
                value: "AreaImages/AA5.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "AreaImages/Statue of Meritamun (The White Queen)2.avif");

            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "AreaImages/Statue of Meritamun (The White Queen)3.jpeg");

            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "AreaImages/Suleiman Agha Al-Selhadar Mosque4.jpeg");

            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "ImageUrl",
                value: "AreaImages/The Way and the Writers of Nafisa Al-Bayda4.jpeg");

            migrationBuilder.UpdateData(
                table: "AreaImages",
                keyColumn: "Id",
                keyValue: 491,
                column: "ImageUrl",
                value: "AreaImages/view-from-sea-urban-development-alexandria-panoramic-view-egypt_431724-5114.avif");
        }
    }
}
