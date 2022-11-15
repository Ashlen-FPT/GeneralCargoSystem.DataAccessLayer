using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralCargoSystem.Data.Migrations
{
    public partial class AddedNewTBLs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_logisticalTransporters",
                table: "logisticalTransporters");

            migrationBuilder.RenameTable(
                name: "logisticalTransporters",
                newName: "LogisticalTransporters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogisticalTransporters",
                table: "LogisticalTransporters",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Commodities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityItem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FPTSites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FPTSites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FPTSiteId = table.Column<int>(type: "int", nullable: false),
                    VesselId = table.Column<int>(type: "int", nullable: false),
                    LogisticalTransporterId = table.Column<int>(type: "int", nullable: false),
                    Registration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CommodityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCBookings_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCBookings_FPTSites_FPTSiteId",
                        column: x => x.FPTSiteId,
                        principalTable: "FPTSites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCBookings_LogisticalTransporters_LogisticalTransporterId",
                        column: x => x.LogisticalTransporterId,
                        principalTable: "LogisticalTransporters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GCBookings_CommodityId",
                table: "GCBookings",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_GCBookings_FPTSiteId",
                table: "GCBookings",
                column: "FPTSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_GCBookings_LogisticalTransporterId",
                table: "GCBookings",
                column: "LogisticalTransporterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GCBookings");

            migrationBuilder.DropTable(
                name: "Commodities");

            migrationBuilder.DropTable(
                name: "FPTSites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogisticalTransporters",
                table: "LogisticalTransporters");

            migrationBuilder.RenameTable(
                name: "LogisticalTransporters",
                newName: "logisticalTransporters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_logisticalTransporters",
                table: "logisticalTransporters",
                column: "Id");
        }
    }
}
