using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeadingDataForPrivateTransportsScoter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PrivateTransports",
                columns: new[] { "Id", "Capacity", "Description", "ImageUrl", "IsAvailable", "Name", "PricePerHour", "Quantity", "TransportTypeId" },
                values: new object[,]
                {
                    { 31, 2, "The scoter is a type of sea duck that lives in cold and temperate regions.", "PrivateTransports/Scoter/1.jpg", true, "Scoter1", 160.0, 4, 3 },
                    { 32, 2, "Scooters are easy to handle and convenient for daily transportation.", "PrivateTransports/Scoter/2.jpg", true, "Scoter2", 250.0, 4, 3 },
                    { 33, 2, "There are three main species of scoter: the black scoter, the surf scoter, and the velvet scoter", "PrivateTransports/Scoter/3.jpg", true, "Scoter3", 200.0, 4, 3 },
                    { 34, 2, "Scoters primarily feed on mollusks, crustaceans, and small fish", "PrivateTransports/Scoter/4.jpg", true, "Scoter4", 170.0, 4, 3 },
                    { 35, 2, "They have dark-colored feathers, with males usually appearing blacker than females.", "PrivateTransports/Scoter/4.jpg", true, "Scoter5", 130.0, 4, 3 },
                    { 36, 2, "Scoters prefer coastal waters and large water bodies like lakes and rivers.", "PrivateTransports/Scoter/5.jpg", true, "Scoter6", 110.0, 4, 3 },
                    { 37, 2, "Electric scooters are commonly used for short-distance travel in cities.", "PrivateTransports/Scoter/2.jpg", true, "Scoter7", 120.0, 4, 3 },
                    { 38, 2, "Kick scooters are popular among children and some commuters.", "PrivateTransports/Scoter/1.jpg", true, "Scoter8", 150.0, 4, 3 },
                    { 39, 2, "Scooters are easy to handle and convenient for daily transportation.", "PrivateTransports/Scoter/1.jpg", true, "Scoter9", 100.0, 4, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PrivateTransports",
                keyColumn: "Id",
                keyValue: 39);
        }
    }
}
