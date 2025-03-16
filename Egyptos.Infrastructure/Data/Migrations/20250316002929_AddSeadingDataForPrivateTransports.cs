using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeadingDataForPrivateTransports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PrivateTransports",
                columns: new[] { "Id", "Capacity", "Description", "ImageUrl", "IsAvailable", "Name", "PricePerHour", "Quantity", "TransportTypeId" },
                values: new object[,]
                {
                    { 1, 4, "Luxury sports sedan with high performance.", "PrivateTransports/Car/bmw-5.jpg", true, "Bmw M5", 50.0, 2, 1 },
                    { 2, 4, "Premium luxury sedan with advanced features.", "PrivateTransports/Car/Mercedes-Benz S-Class.jpeg", true, "Mercedes-Benz S-Class", 60.0, 2, 1 },
                    { 3, 4, "High-end executive car with superior comfort.", "PrivateTransports/Car/Audi A8.jpg", true, "Audi A8", 55.0, 2, 1 },
                    { 4, 4, "Reliable and comfortable sedan for everyday use.", "PrivateTransports/Car/Toyota Camry.webp", true, "Toyota Camry", 30.0, 2, 1 },
                    { 5, 4, "Affordable compact sedan with great fuel efficiency.", "PrivateTransports/Car/Nissan Sunny.jpg", true, "Nissan Sunny", 20.0, 2, 1 },
                    { 6, 4, "Luxury SUV with off-road capability and elegance.", "PrivateTransports/Car/Range Rover Evoque.jpg", true, "Range Rover Evoque", 70.0, 2, 1 },
                    { 7, 7, "Spacious full-size SUV perfect for families and groups.", "PrivateTransports/Car/Chevrolet Tahoe.jpg", true, "Chevrolet Tahoe", 65.0, 2, 1 },
                    { 8, 4, "Economical and stylish sedan with modern features.", "PrivateTransports/Car/Hyundai Elantra.jpeg", true, "Hyundai Elantra", 25.0, 2, 1 },
                    { 9, 4, "Classic American muscle car with powerful performance.", "PrivateTransports/Car/Ford Mustang.jpeg", true, "Ford Mustang", 80.0, 2, 1 },
                    { 10, 4, "Electric luxury sedan with cutting-edge technology.", "PrivateTransports/Car/Tesla Model S.jpg", true, "Tesla Model S", 90.0, 2, 1 },
                    { 11, 5, "Compact SUV with modern features and fuel efficiency.", "PrivateTransports/Car/Kia Sportage.jpg", true, "Kia Sportage", 35.0, 2, 1 },
                    { 12, 4, "Spacious and comfortable sedan with great reliability.", "PrivateTransports/Car/Honda Accord.jpeg", true, "Honda Accord", 40.0, 2, 1 },
                    { 13, 4, "Iconic off-road vehicle for adventure seekers.", "PrivateTransports/Car/Jeep Wrangler.jpeg", true, "Jeep Wrangler", 75.0, 2, 1 },
                    { 14, 4, "Reliable and stylish German sedan.", "PrivateTransports/Car/Volkswagen Passat.jpeg", true, "Volkswagen Passat", 38.0, 2, 1 },
                    { 15, 5, "Luxury sports SUV with high-end features.", "PrivateTransports/Car/Porsche Cayenne.jpg", true, "Porsche Cayenne", 100.0, 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
