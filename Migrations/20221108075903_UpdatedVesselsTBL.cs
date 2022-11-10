using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralCargoSystem.Data.Migrations
{
    public partial class UpdatedVesselsTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Vessels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "VesselNo",
                table: "Vessels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VoyageNo",
                table: "Vessels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Vessels");

            migrationBuilder.DropColumn(
                name: "VesselNo",
                table: "Vessels");

            migrationBuilder.DropColumn(
                name: "VoyageNo",
                table: "Vessels");
        }
    }
}
