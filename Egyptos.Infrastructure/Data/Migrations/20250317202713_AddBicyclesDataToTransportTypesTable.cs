using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBicyclesDataToTransportTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TransportTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "bicycle" });

            migrationBuilder.InsertData(
                table: "PrivateTransports",
                columns: new[] { "Id", "Capacity", "Description", "ImageUrl", "IsAvailable", "Name", "PricePerHour", "Quantity", "TransportTypeId" },
                values: new object[,]
                {
                    { 40, 1, "A sleek and lightweight bicycle built for speed and long-distance rides on paved roads", "PrivateTransports/Bike/Road_Bike.jpg", true, "Road Bike", 70.0, 10, 4 },
                    { 41, 1, "A rugged bike built for off-road trails", "PrivateTransports/Bike/Mountain_Bike.jpg", true, "Mountain Bike", 50.0, 10, 4 },
                    { 42, 1, "Designed for daily urban commuting", "PrivateTransports/Bike/City_Commuter_Bike.jpg", true, "City Commuter Bike", 40.0, 10, 4 },
                    { 43, 1, "A stylish and relaxed bicycle for leisurely rides", "PrivateTransports/Bike/Cruiser_Bike.jpg", true, "Cruiser Bike", 60.0, 10, 4 },
                    { 44, 1, "A modern bicycle with an electric motor and battery for pedal-assist riding, ideal for long distances and commuting with ease and less effort.", "PrivateTransports/Bike/Electric_Bike.jpg", true, "Electric Bike", 140.0, 10, 4 },
                    { 45, 1, "Endurance-focused road bike with IsoSpeed technology for smoother rides over long distances.", "PrivateTransports/Bike/Trek_Domane_SL_6.jpg", true, "Trek Domane SL 6", 150.0, 10, 4 },
                    { 46, 1, "A performance alloy race bike with aggressive geometry, ideal for speed and competitive cycling.", "PrivateTransports/Bike/Specialized.jpg", true, "Specialized Allez Sprint Comp", 170.0, 10, 4 },
                    { 47, 1, "A versatile hardtail mountain bike with front suspension, perfect for beginner to intermediate trail", "PrivateTransports/Bike/Cannondale.jpg", true, "Cannondale Trail 5", 120.0, 10, 4 },
                    { 48, 1, "A lightweight hybrid city bike designed for efficient daily commuting and fitness rides.", "PrivateTransports/Bike/Giant.jpg", true, "Giant Escape 3", 130.0, 10, 4 },
                    { 49, 1, "A commuter-focused e-bike with a powerful motor, integrated lights, and a rear rack.", "PrivateTransports/Bike/Rad_Power.jpg", true, "Rad Power Bikes RadCity 5 Plus", 150.0, 10, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
