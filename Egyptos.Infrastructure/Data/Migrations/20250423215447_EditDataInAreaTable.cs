using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditDataInAreaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "AreaImages/sphinx1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "AreaImages/Aswan Cemetery1.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "AreaImages/Al-Bajwat Cemetery1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "AreaImages/Shatby Cemetery1.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "AreaImages/Palace of King Amenemhat1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "AreaImages/Mohamed Ali Palace in Shubra1.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "AreaImages/Church of the Burning Bush1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "AreaImages/Sultan Al-Ghouri Group1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "AreaImages/9000.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "AreaImages/sphinx1.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "AreaImages/Aswan_Cemetery1.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "AreaImages/Al-Bajwat_Cemetery1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "AreaImages/Shatby_Cemetery1.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "AreaImages/Palace_of_King_Amenemhat1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "AreaImages/Mohamed_Ali_Palace_in_Shubra1.jpeg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "AreaImages/Church_of_the_Burning_Bush1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "AreaImages/Sultan_Al-Ghouri_Group1.jpg");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "AreaImages/900.jpg");
        }
    }
}
