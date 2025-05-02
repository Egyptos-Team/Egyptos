using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class addTripReviewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripReviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripReviews_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActiveToSubscribe",
                value: false);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsActiveToSubscribe",
                value: true);

            migrationBuilder.CreateIndex(
                name: "IX_TripReviews_TripId",
                table: "TripReviews",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_TripReviews_UserId",
                table: "TripReviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripReviews");

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActiveToSubscribe",
                value: true);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsActiveToSubscribe",
                value: false);
        }
    }
}
