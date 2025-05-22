using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTripProgramInAppDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripProgram_Trips_TripId",
                table: "TripProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TripProgram",
                table: "TripProgram");

            migrationBuilder.RenameTable(
                name: "TripProgram",
                newName: "TripPrograms");

            migrationBuilder.RenameIndex(
                name: "IX_TripProgram_TripId",
                table: "TripPrograms",
                newName: "IX_TripPrograms_TripId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TripPrograms",
                table: "TripPrograms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TripPrograms_Trips_TripId",
                table: "TripPrograms",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripPrograms_Trips_TripId",
                table: "TripPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TripPrograms",
                table: "TripPrograms");

            migrationBuilder.RenameTable(
                name: "TripPrograms",
                newName: "TripProgram");

            migrationBuilder.RenameIndex(
                name: "IX_TripPrograms_TripId",
                table: "TripProgram",
                newName: "IX_TripProgram_TripId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TripProgram",
                table: "TripProgram",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TripProgram_Trips_TripId",
                table: "TripProgram",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
