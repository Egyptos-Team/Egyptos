using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateItemsDatePart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: "Items/ivorycomb.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "Items/A reproach illustrating the scene of Jesus Christ's entry into the city of Jerusalem.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: "Items/Coffin of Nedjem Ankh.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                column: "ImageUrl",
                value: "Items/11111.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                column: "ImageUrl",
                value: "Items/6.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: "Items/ivorycomb");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "Items/");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: "Items/Coffin of Najm Ankh.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                column: "ImageUrl",
                value: "Items/Group Statue of Menkaure.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                column: "ImageUrl",
                value: "Items/GunpowderMeasure.jpg");
        }
    }
}
