using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImageInProjecy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb3cb7ca-1921-49fd-a11e-600b351b3df4",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jody", "Hesham" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f89bca4a-8fc9-4259-a46d-22562907c27f",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ahmed", "Mohamed" });

            migrationBuilder.UpdateData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "HistoricalImages/8.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb3cb7ca-1921-49fd-a11e-600b351b3df4",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jessy", "MArk" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f89bca4a-8fc9-4259-a46d-22562907c27f",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Mark", "ALbrto" });

            migrationBuilder.UpdateData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "HistoricalImages/9.jpeg");
        }
    }
}
