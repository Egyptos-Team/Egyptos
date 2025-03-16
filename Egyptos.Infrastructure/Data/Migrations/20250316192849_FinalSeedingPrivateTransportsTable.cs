using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinalSeedingPrivateTransportsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TransportTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Car" },
                    { 2, "Bus" },
                    { 3, "Scoter" }
                });

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
                    { 15, 5, "Luxury sports SUV with high-end features.", "PrivateTransports/Car/Porsche Cayenne.jpg", true, "Porsche Cayenne", 100.0, 2, 1 },
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
                    { 30, 48, "Spacious coach with modern amenities.", "PrivateTransports/Bus/Golden Dragon XML6127.jpeg", true, "Golden Dragon XML6127", 160.0, 2, 2 },
                    { 31, 2, "The scoter is a type of sea duck that lives in cold and temperate regions.", "PrivateTransports/Damon Hypersport.webp", true, "Damon Hypersport", 160.0, 4, 3 },
                    { 32, 2, "Scooters are easy to handle and convenient for daily transportation.", "PrivateTransports/Honda CB650R.jpg", true, "Honda CB650R", 250.0, 4, 3 },
                    { 33, 2, "There are three main species of scoter: the black scoter, the surf scoter, and the velvet scoter", "PrivateTransports/Honda CBR1000RR Fireblade.png", true, "Honda CBR1000RR Fireblade", 200.0, 4, 3 },
                    { 34, 2, "Scoters primarily feed on mollusks, crustaceans, and small fish", "PrivateTransports/Kawasaki Ninja.jpeg", true, "Kawasaki Ninja", 170.0, 4, 3 },
                    { 35, 2, "They have dark-colored feathers, with males usually appearing blacker than females.", "PrivateTransports/KTM Duke 1290 R.jpg", true, "KTM Duke 1290 R", 130.0, 4, 3 },
                    { 36, 2, "Scoters prefer coastal waters and large water bodies like lakes and rivers.", "PrivateTransports/Lightning LS-218.jpg", true, "Lightning LS-218", 110.0, 4, 3 },
                    { 37, 2, "Electric scooters are commonly used for short-distance travel in cities.", "PrivateTransports/my22-tiger-1200-gt-explorer-lucerne-blue-rhs-1080.png", true, "my22-tiger-1200-gt-explorer", 120.0, 4, 3 },
                    { 38, 2, "Kick scooters are popular among children and some commuters.", "PrivateTransports/Suzuki GSX R1000.jpeg", true, "Suzuki GSX R1000", 150.0, 4, 3 },
                    { 39, 2, "Scooters are easy to handle and convenient for daily transportation.", "PrivateTransports/Yamaha YZF.jpg", true, "Yamaha YZF", 100.0, 4, 3 }
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

            migrationBuilder.DeleteData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TransportTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
