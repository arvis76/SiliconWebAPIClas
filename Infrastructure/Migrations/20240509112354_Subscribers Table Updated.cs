using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SubscribersTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeekinReviw",
                table: "subscribers",
                newName: "WeekinReview");

            migrationBuilder.RenameColumn(
                name: "StartUpdate",
                table: "subscribers",
                newName: "StartUpsWeekly");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeekinReview",
                table: "subscribers",
                newName: "WeekinReviw");

            migrationBuilder.RenameColumn(
                name: "StartUpsWeekly",
                table: "subscribers",
                newName: "StartUpdate");
        }
    }
}
