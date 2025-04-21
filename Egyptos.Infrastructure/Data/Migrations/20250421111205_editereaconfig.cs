using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class editereaconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 30.5703, 31.5059 });

            migrationBuilder.InsertData(
                table: "PublicTransports",
                columns: new[] { "Id", "Capacity", "ImageUrl", "IsAvailable", "Name", "SerialNumber" },
                values: new object[] { 1, 50, "PublicTransportmages/1.webp", 1, "Bus", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.823099999999997, 20.449200000000001 });
        }
    }
}
