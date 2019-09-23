using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class Removedversionfromcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "VersionPicture",
                table: "Categories",
                newName: "CategoryPictureId");

            migrationBuilder.AddColumn<string>(
                name: "VersionPicture",
                table: "CategoryPictures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VersionPicture",
                table: "CategoryPictures");

            migrationBuilder.RenameColumn(
                name: "CategoryPictureId",
                table: "Categories",
                newName: "VersionPicture");

            migrationBuilder.AddColumn<string>(
                name: "PictureId",
                table: "Categories",
                nullable: true);
        }
    }
}
