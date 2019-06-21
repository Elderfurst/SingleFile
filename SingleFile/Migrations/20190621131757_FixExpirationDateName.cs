using Microsoft.EntityFrameworkCore.Migrations;

namespace SingleFile.Migrations
{
    public partial class FixExpirationDateName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExprationDate",
                table: "Files",
                newName: "ExpirationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "Files",
                newName: "ExprationDate");
        }
    }
}
