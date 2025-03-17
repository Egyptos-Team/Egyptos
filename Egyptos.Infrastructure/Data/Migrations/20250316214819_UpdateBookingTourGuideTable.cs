using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookingTourGuideTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingTourGuides",
                table: "BookingTourGuides");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookingTourGuides",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelBooking",
                table: "BookingTourGuides",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentCancel",
                table: "BookingTourGuides",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "BookingTourGuides",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingTourGuides",
                table: "BookingTourGuides",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTourGuides_TourGuideId",
                table: "BookingTourGuides",
                column: "TourGuideId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingTourGuides",
                table: "BookingTourGuides");

            migrationBuilder.DropIndex(
                name: "IX_BookingTourGuides_TourGuideId",
                table: "BookingTourGuides");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookingTourGuides");

            migrationBuilder.DropColumn(
                name: "CancelBooking",
                table: "BookingTourGuides");

            migrationBuilder.DropColumn(
                name: "PaymentCancel",
                table: "BookingTourGuides");

            migrationBuilder.DropColumn(
                name: "PaymentDate",
                table: "BookingTourGuides");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingTourGuides",
                table: "BookingTourGuides",
                columns: new[] { "TourGuideId", "UserId" });
        }
    }
}
