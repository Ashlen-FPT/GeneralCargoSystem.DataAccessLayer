using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralCargoSystem.Data.Migrations
{
    public partial class UpdatedLogsTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalData",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalData",
                table: "Logs");
        }
    }
}
