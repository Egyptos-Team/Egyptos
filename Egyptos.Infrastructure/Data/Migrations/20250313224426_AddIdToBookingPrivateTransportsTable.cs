using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToBookingPrivateTransportsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingPrivateTransports",
                table: "BookingPrivateTransports");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookingPrivateTransports",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingPrivateTransports",
                table: "BookingPrivateTransports",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookingPrivateTransports_UserId",
                table: "BookingPrivateTransports",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingPrivateTransports",
                table: "BookingPrivateTransports");

            migrationBuilder.DropIndex(
                name: "IX_BookingPrivateTransports_UserId",
                table: "BookingPrivateTransports");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookingPrivateTransports");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingPrivateTransports",
                table: "BookingPrivateTransports",
                columns: new[] { "UserId", "PrivateTransportId" });
        }
    }
}
