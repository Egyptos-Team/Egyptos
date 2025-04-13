using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class editInTableItemsAddAreaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Areas_AreaId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActiveToSubscribe",
                value: false);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActiveToSubscribe",
                value: true);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsActiveToSubscribe",
                value: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Areas_AreaId",
                table: "Items",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Areas_AreaId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActiveToSubscribe",
                value: true);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActiveToSubscribe",
                value: false);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsActiveToSubscribe",
                value: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Areas_AreaId",
                table: "Items",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id");
        }
    }
}
