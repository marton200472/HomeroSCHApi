using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeroSCHApi.Migrations
{
    /// <inheritdoc />
    public partial class fix_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Measurements_LocationId",
                table: "Measurements",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Locations_LocationId",
                table: "Measurements",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_Locations_LocationId",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_LocationId",
                table: "Measurements");
        }
    }
}
