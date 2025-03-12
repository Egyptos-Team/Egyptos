using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixBookingTourGuide : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTourGuides_Trips_TripId",
                table: "BookingTourGuides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingTourGuides",
                table: "BookingTourGuides");

            migrationBuilder.DropIndex(
                name: "IX_BookingTourGuides_TripId",
                table: "BookingTourGuides");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "BookingTourGuides");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BookingTourGuides",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingTourGuides",
                table: "BookingTourGuides",
                columns: new[] { "TourGuideId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_BookingTourGuides_UserId",
                table: "BookingTourGuides",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTourGuides_AspNetUsers_UserId",
                table: "BookingTourGuides",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTourGuides_AspNetUsers_UserId",
                table: "BookingTourGuides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingTourGuides",
                table: "BookingTourGuides");

            migrationBuilder.DropIndex(
                name: "IX_BookingTourGuides_UserId",
                table: "BookingTourGuides");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BookingTourGuides");

            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "BookingTourGuides",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingTourGuides",
                table: "BookingTourGuides",
                columns: new[] { "TourGuideId", "TripId" });

            migrationBuilder.CreateIndex(
                name: "IX_BookingTourGuides_TripId",
                table: "BookingTourGuides",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTourGuides_Trips_TripId",
                table: "BookingTourGuides",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
