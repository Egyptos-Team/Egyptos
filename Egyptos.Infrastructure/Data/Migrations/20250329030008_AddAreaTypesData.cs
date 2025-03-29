using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAreaTypesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AreaTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fixed artifacts" },
                    { 2, "Archaeological sites" },
                    { 3, "Sunken artifacts" },
                    { 4, "Safari" },
                    { 5, "Marine and Nile" },
                    { 6, "Mountainous" },
                    { 7, "Rural and natural" },
                    { 8, "Museums" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AreaTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AreaTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AreaTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AreaTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AreaTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AreaTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AreaTypes",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
