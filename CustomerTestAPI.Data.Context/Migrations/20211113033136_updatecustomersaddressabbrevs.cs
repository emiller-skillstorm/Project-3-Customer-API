using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerTestAPI.Data.Context.Migrations
{
    public partial class updatecustomersaddressabbrevs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Coordinates_CoordinatesId",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "LName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "FName");

            migrationBuilder.RenameColumn(
                name: "Street_2",
                table: "Address",
                newName: "Street2");

            migrationBuilder.RenameColumn(
                name: "Street_1",
                table: "Address",
                newName: "Street1");

            migrationBuilder.RenameColumn(
                name: "CoordinatesId",
                table: "Address",
                newName: "CoordId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CoordinatesId",
                table: "Address",
                newName: "IX_Address_CoordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Coordinates_CoordId",
                table: "Address",
                column: "CoordId",
                principalTable: "Coordinates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Coordinates_CoordId",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FName",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Street2",
                table: "Address",
                newName: "Street_2");

            migrationBuilder.RenameColumn(
                name: "Street1",
                table: "Address",
                newName: "Street_1");

            migrationBuilder.RenameColumn(
                name: "CoordId",
                table: "Address",
                newName: "CoordinatesId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CoordId",
                table: "Address",
                newName: "IX_Address_CoordinatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Coordinates_CoordinatesId",
                table: "Address",
                column: "CoordinatesId",
                principalTable: "Coordinates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
