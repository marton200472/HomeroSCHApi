using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeroSCHApi.Migrations
{
    /// <inheritdoc />
    public partial class rename_measurements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurement_Devices_DeviceId",
                table: "Measurement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurement",
                table: "Measurement");

            migrationBuilder.RenameTable(
                name: "Measurement",
                newName: "Measurements");

            migrationBuilder.RenameIndex(
                name: "IX_Measurement_DeviceId",
                table: "Measurements",
                newName: "IX_Measurements_DeviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Devices_DeviceId",
                table: "Measurements",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_Devices_DeviceId",
                table: "Measurements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements");

            migrationBuilder.RenameTable(
                name: "Measurements",
                newName: "Measurement");

            migrationBuilder.RenameIndex(
                name: "IX_Measurements_DeviceId",
                table: "Measurement",
                newName: "IX_Measurement_DeviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurement",
                table: "Measurement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurement_Devices_DeviceId",
                table: "Measurement",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
