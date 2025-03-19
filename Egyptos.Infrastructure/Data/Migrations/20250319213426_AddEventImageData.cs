using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEventImageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventImages",
                columns: new[] { "Id", "EventId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "EventImages/Ismailia/1.webp" },
                    { 2, 1, "EventImages/Ismailia/2.webp" },
                    { 3, 1, "EventImages/Ismailia/3.webp" },
                    { 4, 2, "EventImages/Alexandria/1.webp" },
                    { 5, 2, "EventImages/Alexandria/2.webp" },
                    { 6, 2, "EventImages/Alexandria/3.webp" },
                    { 7, 3, "EventImages/Cairo/1.webp" },
                    { 8, 3, "EventImages/Cairo/2.webp" },
                    { 9, 3, "EventImages/Cairo/3.webp" },
                    { 10, 4, "EventImages/Karnak Temple, Luxor, Egypt/1.webp" },
                    { 11, 4, "EventImages/Karnak Temple, Luxor, Egypt/2.webp" },
                    { 12, 4, "EventImages/Karnak Temple, Luxor, Egypt/3.webp" },
                    { 13, 5, "EventImages/Cairo,Egypt/1.webp" },
                    { 14, 5, "EventImages/Cairo,Egypt/2.webp" },
                    { 15, 5, "EventImages/Cairo,Egypt/3.webp" },
                    { 16, 6, "EventImages/Giza Pyramids, Egypt/1.webp" },
                    { 17, 6, "EventImages/Giza Pyramids, Egypt/2.webp" },
                    { 18, 6, "EventImages/Giza Pyramids, Egypt/3.webp" },
                    { 19, 7, "EventImages/Cairo, Egypt2/1.webp" },
                    { 20, 7, "EventImages/Cairo, Egypt2/2.webp" },
                    { 21, 7, "EventImages/Cairo, Egypt2/3.webp" },
                    { 22, 8, "EventImages/Hurghada, Egypt/1.webp" },
                    { 23, 8, "EventImages/Hurghada, Egypt/2.webp" },
                    { 24, 8, "EventImages/Hurghada, Egypt/3.webp" },
                    { 25, 9, "EventImages/Sharm El Sheikh, Egypt/1.webp" },
                    { 26, 9, "EventImages/Sharm El Sheikh, Egypt/2.webp" },
                    { 27, 9, "EventImages/Sharm El Sheikh, Egypt/3.webp" },
                    { 28, 10, "EventImages/Cairo Museum/1.webp" },
                    { 29, 10, "EventImages/Cairo Museum/2.webp" },
                    { 30, 10, "EventImages/Cairo Museum/3.webp" },
                    { 31, 11, "EventImages/Al Azhar Mosque/1.webp" },
                    { 32, 11, "EventImages/Al Azhar Mosque/2.webp" },
                    { 33, 11, "EventImages/Al Azhar Mosque/3.webp" },
                    { 34, 12, "EventImages/Giza Plateau/1.webp" },
                    { 35, 12, "EventImages/Giza Plateau/2.webp" },
                    { 36, 12, "EventImages/Giza Plateau/3.webp" },
                    { 37, 13, "EventImages/El Gouna, Red Sea/1.webp" },
                    { 38, 13, "EventImages/El Gouna, Red Sea/2.webp" },
                    { 39, 13, "EventImages/El Gouna, Red Sea/3.webp" },
                    { 40, 15, "EventImages/40.jpg" },
                    { 41, 15, "EventImages/41.jpg" },
                    { 42, 15, "EventImages/42.jpg" },
                    { 43, 16, "EventImages/43.jpg" },
                    { 44, 16, "EventImages/44.jpg" },
                    { 45, 16, "EventImages/45.jpg" },
                    { 46, 17, "EventImages/46.jpg" },
                    { 47, 17, "EventImages/47.jpg" },
                    { 48, 17, "EventImages/48.jpg" },
                    { 49, 18, "EventImages/49.jpg" },
                    { 50, 18, "EventImages/50.jpg" },
                    { 51, 18, "EventImages/51.jpg" },
                    { 52, 19, "EventImages/52.jpg" },
                    { 53, 19, "EventImages/53.jpg" },
                    { 54, 19, "EventImages/54.jpg" },
                    { 55, 20, "EventImages/55.jpg" },
                    { 56, 20, "EventImages/56.jpg" },
                    { 57, 20, "EventImages/57.jpg" },
                    { 58, 21, "EventImages/58.jpg" },
                    { 59, 21, "EventImages/59.jpg" },
                    { 60, 21, "EventImages/60.jpg" },
                    { 61, 22, "EventImages/61.jpg" },
                    { 62, 22, "EventImages/62.jpg" },
                    { 63, 22, "EventImages/63.jpg" },
                    { 64, 23, "EventImages/64.jpg" },
                    { 65, 23, "EventImages/65.jpg" },
                    { 66, 23, "EventImages/66.jpg" },
                    { 67, 24, "EventImages/67.jpg" },
                    { 68, 24, "EventImages/68.jpg" },
                    { 69, 24, "EventImages/69.jpg" },
                    { 70, 25, "EventImages/70.jpg" },
                    { 71, 25, "EventImages/71.jpg" },
                    { 72, 25, "EventImages/72.jpg" },
                    { 73, 25, "EventImages/73.jpg" },
                    { 74, 25, "EventImages/74.jpg" },
                    { 75, 25, "EventImages/75.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 43);

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
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 69);

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

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 75);
        }
    }
}
