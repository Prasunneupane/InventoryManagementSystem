using Microsoft.EntityFrameworkCore.Migrations;

namespace InventorymanagementSystme.Data.Migrations
{
    public partial class Item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Items");

            migrationBuilder.RenameColumn(
                name: "SurName",
                table: "Items",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Items",
                newName: "Feature");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Items",
                newName: "BrandName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Employees",
                newName: "SurName");

            migrationBuilder.RenameColumn(
                name: "Feature",
                table: "Employees",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "BrandName",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "Employees",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
