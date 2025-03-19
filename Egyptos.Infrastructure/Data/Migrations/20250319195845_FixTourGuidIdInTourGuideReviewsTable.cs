using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTourGuidIdInTourGuideReviewsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TourId",
                table: "TourGuideReviews");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "TourGuideReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
