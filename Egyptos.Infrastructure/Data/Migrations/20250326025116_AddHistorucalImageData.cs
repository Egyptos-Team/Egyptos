using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddHistorucalImageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HistoricalImages",
                columns: new[] { "Id", "HistoricalId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "HistoricalImages/2.jpg" },
                    { 2, 1, "HistoricalImages/3.jpg" },
                    { 3, 1, "HistoricalImages/4.jpg" },
                    { 4, 1, "HistoricalImages/5.jpg" },
                    { 5, 2, "HistoricalImages/6.jpeg" },
                    { 6, 2, "HistoricalImages/7.jpeg" },
                    { 7, 2, "HistoricalImages/9.jpeg" },
                    { 8, 2, "HistoricalImages/10.jpeg" },
                    { 9, 3, "HistoricalImages/11.jpg" },
                    { 10, 3, "HistoricalImages/13.jpg" },
                    { 11, 3, "HistoricalImages/14.jpg" },
                    { 12, 3, "HistoricalImages/15.jpg" },
                    { 13, 4, "HistoricalImages/17.jpg" },
                    { 14, 4, "HistoricalImages/18.jpg" },
                    { 15, 4, "HistoricalImages/19.jpg" },
                    { 16, 4, "HistoricalImages/20.jpg" },
                    { 17, 5, "HistoricalImages/21.jpg" },
                    { 18, 5, "HistoricalImages/23.jpg" },
                    { 19, 5, "HistoricalImages/24.jpg" },
                    { 20, 5, "HistoricalImages/25.jpg" },
                    { 21, 6, "HistoricalImages/27.jpg" },
                    { 22, 6, "HistoricalImages/28.jpg" },
                    { 23, 6, "HistoricalImages/29.jpg" },
                    { 24, 6, "HistoricalImages/30.jpg" },
                    { 25, 7, "HistoricalImages/32.jpeg" },
                    { 26, 7, "HistoricalImages/33.jpg" },
                    { 27, 7, "HistoricalImages/34.jpg" },
                    { 28, 7, "HistoricalImages/35.jpg" },
                    { 29, 8, "HistoricalImages/37.jpg" },
                    { 30, 8, "HistoricalImages/38.jpg" },
                    { 31, 8, "HistoricalImages/39.jpg" },
                    { 32, 8, "HistoricalImages/40.jpg" },
                    { 33, 9, "HistoricalImages/42.jpg" },
                    { 34, 9, "HistoricalImages/43.jpg" },
                    { 35, 9, "HistoricalImages/44.jpg" },
                    { 36, 9, "HistoricalImages/45.jpg" },
                    { 37, 10, "HistoricalImages/47.jpg" },
                    { 38, 10, "HistoricalImages/48.jpg" },
                    { 39, 10, "HistoricalImages/49.jpg" },
                    { 40, 10, "HistoricalImages/50.jpg" },
                    { 41, 11, "HistoricalImages/52.jpg" },
                    { 42, 11, "HistoricalImages/53.jpg" },
                    { 43, 11, "HistoricalImages/54.jpg" },
                    { 44, 11, "HistoricalImages/55.jpg" },
                    { 45, 12, "HistoricalImages/57.jpg" },
                    { 46, 12, "HistoricalImages/58.jpg" },
                    { 47, 12, "HistoricalImages/59.jpg" },
                    { 48, 12, "HistoricalImages/60.webp" },
                    { 49, 13, "HistoricalImages/61.jpg" },
                    { 50, 13, "HistoricalImages/62.jpg" },
                    { 51, 13, "HistoricalImages/64.jpg" },
                    { 52, 13, "HistoricalImages/65.jpg" },
                    { 53, 14, "HistoricalImages/66.jpg" },
                    { 54, 14, "HistoricalImages/67.jpg" },
                    { 55, 14, "HistoricalImages/68.jpg" },
                    { 56, 14, "HistoricalImages/70.jpg" },
                    { 57, 15, "HistoricalImages/72.jpg" },
                    { 58, 15, "HistoricalImages/73.jpeg" },
                    { 59, 15, "HistoricalImages/74.jpg" },
                    { 60, 15, "HistoricalImages/75.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "HistoricalImages",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}
