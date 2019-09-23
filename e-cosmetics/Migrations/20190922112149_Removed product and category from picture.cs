using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class Removedproductandcategoryfrompicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Categories_CategoryId",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Products_ProductId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_CategoryId",
                table: "Pictures");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Pictures",
                newName: "Url");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Pictures",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PictureId",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PictureId",
                table: "Categories",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Pictures_PictureId",
                table: "Categories",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Categories_Pictures_PictureId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Products_ProductId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PictureId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Pictures",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Pictures",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PictureId",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_CategoryId",
                table: "Pictures",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Categories_CategoryId",
                table: "Pictures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Products_ProductId",
                table: "Pictures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
