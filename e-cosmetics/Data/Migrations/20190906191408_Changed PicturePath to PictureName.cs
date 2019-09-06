using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Data.Migrations
{
    public partial class ChangedPicturePathtoPictureName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PicturePath",
                table: "Categories",
                newName: "PictureName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureName",
                table: "Categories",
                newName: "PicturePath");
        }
    }
}
