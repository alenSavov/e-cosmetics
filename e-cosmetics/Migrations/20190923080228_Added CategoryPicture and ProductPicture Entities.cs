using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class AddedCategoryPictureandProductPictureEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Products_ProductId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_ProductId",
                table: "Pictures");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Pictures",
                newName: "VersionPicture");

            migrationBuilder.AlterColumn<string>(
                name: "VersionPicture",
                table: "Pictures",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VersionPicture",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryPictures",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryPictures_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPictures",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPictures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPictures_CategoryId",
                table: "CategoryPictures",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPictures_ProductId",
                table: "ProductPictures",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPictures");

            migrationBuilder.DropTable(
                name: "ProductPictures");

            migrationBuilder.DropColumn(
                name: "VersionPicture",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "VersionPicture",
                table: "Pictures",
                newName: "ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Pictures",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
