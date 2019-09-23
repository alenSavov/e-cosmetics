using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class AddedFoldertoCateroryPictureandProductPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Folder",
                table: "ProductPictures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Folder",
                table: "CategoryPictures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Folder",
                table: "ProductPictures");

            migrationBuilder.DropColumn(
                name: "Folder",
                table: "CategoryPictures");
        }
    }
}
