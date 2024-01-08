using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ParkingManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ParkingSlots",
                columns: new[] { "SlotNumber", "IsAvailable", "SlotType" },
                values: new object[,]
                {
                    { 1, true, 0 },
                    { 2, true, 0 },
                    { 3, true, 0 },
                    { 4, true, 0 },
                    { 5, true, 0 },
                    { 6, true, 0 },
                    { 7, true, 0 },
                    { 8, true, 0 },
                    { 9, true, 0 },
                    { 10, true, 0 },
                    { 11, true, 0 },
                    { 12, true, 0 },
                    { 13, true, 0 },
                    { 14, true, 0 },
                    { 15, true, 0 },
                    { 16, true, 0 },
                    { 17, true, 0 },
                    { 18, true, 0 },
                    { 19, true, 0 },
                    { 20, true, 0 },
                    { 21, true, 0 },
                    { 22, true, 0 },
                    { 23, true, 0 },
                    { 24, true, 0 },
                    { 25, true, 0 },
                    { 26, true, 0 },
                    { 27, true, 0 },
                    { 28, true, 0 },
                    { 29, true, 0 },
                    { 30, true, 0 },
                    { 31, true, 0 },
                    { 32, true, 0 },
                    { 33, true, 0 },
                    { 34, true, 0 },
                    { 35, true, 0 },
                    { 36, true, 0 },
                    { 37, true, 0 },
                    { 38, true, 0 },
                    { 39, true, 0 },
                    { 40, true, 0 },
                    { 41, true, 0 },
                    { 42, true, 0 },
                    { 43, true, 0 },
                    { 44, true, 0 },
                    { 45, true, 0 },
                    { 46, true, 0 },
                    { 47, true, 0 },
                    { 48, true, 0 },
                    { 49, true, 0 },
                    { 50, true, 0 },
                    { 51, true, 1 },
                    { 52, true, 1 },
                    { 53, true, 1 },
                    { 54, true, 1 },
                    { 55, true, 1 },
                    { 56, true, 1 },
                    { 57, true, 1 },
                    { 58, true, 1 },
                    { 59, true, 1 },
                    { 60, true, 1 },
                    { 61, true, 1 },
                    { 62, true, 1 },
                    { 63, true, 1 },
                    { 64, true, 1 },
                    { 65, true, 1 },
                    { 66, true, 1 },
                    { 67, true, 1 },
                    { 68, true, 1 },
                    { 69, true, 1 },
                    { 70, true, 1 },
                    { 71, true, 1 },
                    { 72, true, 1 },
                    { 73, true, 1 },
                    { 74, true, 1 },
                    { 75, true, 1 },
                    { 76, true, 1 },
                    { 77, true, 1 },
                    { 78, true, 1 },
                    { 79, true, 1 },
                    { 80, true, 1 },
                    { 81, true, 2 },
                    { 82, true, 2 },
                    { 83, true, 2 },
                    { 84, true, 2 },
                    { 85, true, 2 },
                    { 86, true, 2 },
                    { 87, true, 2 },
                    { 88, true, 2 },
                    { 89, true, 2 },
                    { 90, true, 2 },
                    { 91, true, 2 },
                    { 92, true, 2 },
                    { 93, true, 2 },
                    { 94, true, 2 },
                    { 95, true, 2 },
                    { 96, true, 2 },
                    { 97, true, 2 },
                    { 98, true, 2 },
                    { 99, true, 2 },
                    { 100, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "VehicleTypeName", "CompatibleSlotTypes" },
                values: new object[,]
                {
                    { "Hatchback", "[0,1,2]" },
                    { "Sedan/Compact SUV", "[1,2]" },
                    { "SUV or Large cars", "[2]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "SlotNumber",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeName",
                keyValue: "Hatchback");

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeName",
                keyValue: "Sedan/Compact SUV");

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeName",
                keyValue: "SUV or Large cars");
        }
    }
}
