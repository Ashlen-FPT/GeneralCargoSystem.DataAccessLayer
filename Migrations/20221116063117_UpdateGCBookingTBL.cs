using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralCargoSystem.Data.Migrations
{
    public partial class UpdateGCBookingTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "GCBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "GCBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCBookings_VesselId",
                table: "GCBookings",
                column: "VesselId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCBookings_Vessels_VesselId",
                table: "GCBookings",
                column: "VesselId",
                principalTable: "Vessels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCBookings_Vessels_VesselId",
                table: "GCBookings");

            migrationBuilder.DropIndex(
                name: "IX_GCBookings_VesselId",
                table: "GCBookings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "GCBookings");

            migrationBuilder.DropColumn(
                name: "comments",
                table: "GCBookings");
        }
    }
}
