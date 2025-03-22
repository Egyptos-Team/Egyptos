using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataInTransportTypesTableAddSeadingForImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "TransportTypes/Cars.jpg");

            migrationBuilder.UpdateData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "TransportTypes/Buses.jpg");

            migrationBuilder.UpdateData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "TransportTypes/Scoters.jpg");

            migrationBuilder.UpdateData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "TransportTypes/Bikes.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);
        }
    }
}
