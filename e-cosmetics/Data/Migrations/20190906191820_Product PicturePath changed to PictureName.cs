using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Data.Migrations
{
    public partial class ProductPicturePathchangedtoPictureName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PicturePath",
                table: "Products",
                newName: "PictureName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureName",
                table: "Products",
                newName: "PicturePath");
        }
    }
}
