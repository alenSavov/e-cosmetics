using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class AddedVersionPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VersionPicture",
                table: "ProductPictures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VersionPicture",
                table: "ProductPictures");
        }
    }
}
