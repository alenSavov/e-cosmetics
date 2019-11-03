using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class Changedproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bg",
                table: "localizations");

            migrationBuilder.RenameColumn(
                name: "En",
                table: "localizations",
                newName: "lang");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lang",
                table: "localizations",
                newName: "En");

            migrationBuilder.AddColumn<string>(
                name: "Bg",
                table: "localizations",
                nullable: true);
        }
    }
}
