using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDataInPublicTransport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PublicTransports",
                columns: new[] { "Id", "Capacity", "ImageUrl", "IsAvailable", "Name", "SerialNumber" },
                values: new object[] { 1, 50, "PublicTransportmages/1.webp", 1, "Bus", 1 });
        }
    }
}
