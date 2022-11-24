using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralCargoSystem.Data.Migrations
{
    public partial class UpdatedBoookingsTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "comments",
                table: "GCBookings",
                newName: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comments",
                table: "GCBookings",
                newName: "comments");
        }
    }
}
