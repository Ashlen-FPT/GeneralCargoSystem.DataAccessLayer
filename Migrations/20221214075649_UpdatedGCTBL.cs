using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralCargoSystem.Data.Migrations
{
    public partial class UpdatedGCTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Trade",
                table: "GCBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trade",
                table: "GCBookings");
        }
    }
}
