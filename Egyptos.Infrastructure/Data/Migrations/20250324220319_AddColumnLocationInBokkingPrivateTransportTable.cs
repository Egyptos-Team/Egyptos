using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnLocationInBokkingPrivateTransportTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "BookingPrivateTransports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsActiveToSubscribe",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "BookingPrivateTransports");

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsActiveToSubscribe",
                value: true);
        }
    }
}
