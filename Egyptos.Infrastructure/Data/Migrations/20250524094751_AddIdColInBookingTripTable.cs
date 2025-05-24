using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdColInBookingTripTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingTrips",
                table: "BookingTrips");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookingTrips",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfTickets",
                table: "BookingTrips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingTrips",
                table: "BookingTrips",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTrips_UserId",
                table: "BookingTrips",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingTrips",
                table: "BookingTrips");

            migrationBuilder.DropIndex(
                name: "IX_BookingTrips_UserId",
                table: "BookingTrips");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookingTrips");

            migrationBuilder.DropColumn(
                name: "NumberOfTickets",
                table: "BookingTrips");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingTrips",
                table: "BookingTrips",
                columns: new[] { "UserId", "TripId" });
        }
    }
}
