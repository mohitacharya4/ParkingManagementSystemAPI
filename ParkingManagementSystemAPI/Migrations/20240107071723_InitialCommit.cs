using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingSlots",
                columns: table => new
                {
                    SlotNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlotType = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSlots", x => x.SlotNumber);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    VehicleTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompatibleSlotTypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.VehicleTypeName);
                });

            migrationBuilder.CreateTable(
                name: "ParkingAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlotId = table.Column<int>(type: "int", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleTypeName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkingAssignments_ParkingSlots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "ParkingSlots",
                        principalColumn: "SlotNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParkingAssignments_VehicleTypes_VehicleTypeName",
                        column: x => x.VehicleTypeName,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeName");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkingAssignments_SlotId",
                table: "ParkingAssignments",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingAssignments_VehicleTypeName",
                table: "ParkingAssignments",
                column: "VehicleTypeName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingAssignments");

            migrationBuilder.DropTable(
                name: "ParkingSlots");

            migrationBuilder.DropTable(
                name: "VehicleTypes");
        }
    }
}
