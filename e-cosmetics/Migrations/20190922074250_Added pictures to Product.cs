using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class AddedpicturestoProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureName",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Pictures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ProductId",
                table: "Pictures",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Products_ProductId",
                table: "Pictures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Products_ProductId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_ProductId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Pictures");

            migrationBuilder.AddColumn<string>(
                name: "PictureName",
                table: "Products",
                nullable: true);
        }
    }
}
