using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSameDataInEventImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 72);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventImages",
                columns: new[] { "Id", "EventId", "ImageUrl" },
                values: new object[,]
                {
                    { 44, 16, "EventImages/44.jpg" },
                    { 45, 16, "EventImages/45.jpg" },
                    { 70, 25, "EventImages/70.jpg" },
                    { 71, 25, "EventImages/71.jpg" },
                    { 72, 25, "EventImages/72.jpg" }
                });
        }
    }
}
