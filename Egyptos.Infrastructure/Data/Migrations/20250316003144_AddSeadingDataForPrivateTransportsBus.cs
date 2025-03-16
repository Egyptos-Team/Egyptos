using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeadingDataForPrivateTransportsBus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PrivateTransports",
                columns: new[] { "Id", "Capacity", "Description", "ImageUrl", "IsAvailable", "Name", "PricePerHour", "Quantity", "TransportTypeId" },
                values: new object[,]
                {
                    { 16, 15, "Luxury minibus with premium comfort.", "PrivateTransports/Bus/Mercedes-Benz Sprinter.jpg", true, "Mercedes-Benz Sprinter", 100.0, 2, 2 },
                    { 17, 22, "Comfortable mid-sized bus for group travel.", "PrivateTransports/Bus/Toyota Coaster.jpeg", true, "Toyota Coaster", 80.0, 2, 2 },
                    { 18, 20, "Efficient minibus for short trips.", "PrivateTransports/Bus/Hyundai County.jpeg", true, "Hyundai County", 75.0, 2, 2 },
                    { 19, 26, "Reliable minibus for tourism and business trips.", "PrivateTransports/Bus/Mitsubishi Rosa.jpg", true, "Mitsubishi Rosa", 85.0, 2, 2 },
                    { 20, 50, "Luxury long-distance coach with high-end features.", "PrivateTransports/Bus/Volvo 9700.jpg", true, "Volvo 9700", 200.0, 2, 2 },
                    { 21, 50, "Premium luxury coach for VIP travel.", "PrivateTransports/Bus/Setra TopClass.jpeg", true, "Setra TopClass", 220.0, 2, 2 },
                    { 22, 18, "Economical minibus for group transport.", "PrivateTransports/Bus/Iveco Daily Minibus.jpeg", true, "Iveco Daily Minibus", 90.0, 2, 2 },
                    { 23, 35, "Spacious tourist bus for comfortable travel.", "PrivateTransports/Bus/King Long XMQ6900.jpg", true, "King Long XMQ6900", 110.0, 2, 2 },
                    { 24, 55, "Luxury coach with modern amenities.", "PrivateTransports/Bus/Scania Touring HD.jpg", true, "Scania Touring HD", 180.0, 2, 2 },
                    { 25, 50, "High-end tourist coach for long-distance trips.", "PrivateTransports/Bus/MAN Lion’s Coach.jpeg", true, "MAN Lion’s Coach", 195.0, 2, 2 },
                    { 26, 55, "Luxury coach designed for tourism and comfort.", "PrivateTransports/Bus/Mercedes Tourismo.jpeg", true, "Mercedes Tourismo", 210.0, 2, 2 },
                    { 27, 80, "Double-decker coach for large group tours.", "PrivateTransports/Bus/Neoplan Skyliner.jpg", true, "Neoplan Skyliner", 250.0, 2, 2 },
                    { 28, 45, "Reliable and affordable coach for daily transport.", "PrivateTransports/Bus/Yutong ZK6122.jpeg", true, "Yutong ZK6122", 140.0, 2, 2 },
                    { 29, 50, "High-performance luxury coach for premium travel.", "PrivateTransports/Bus/Volvo B11R.jpeg", true, "Volvo B11R", 230.0, 2, 2 },
                    { 30, 48, "Spacious coach with modern amenities.", "PrivateTransports/Bus/Golden Dragon XML6127.jpeg", true, "Golden Dragon XML6127", 160.0, 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
