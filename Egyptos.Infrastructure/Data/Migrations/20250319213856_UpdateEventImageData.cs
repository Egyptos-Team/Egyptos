using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEventImageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "EventId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "EventId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "EventId",
                value: 14);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "EventId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "EventId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "EventId",
                value: 25);
        }
    }
}
