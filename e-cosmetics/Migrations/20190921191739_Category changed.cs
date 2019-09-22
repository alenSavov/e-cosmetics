using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class Categorychanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Pictures_PictureId1",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PictureId1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "PictureId1",
                table: "Categories");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Pictures_PictureId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PictureId",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "Pictures",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PictureId",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureId1",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PictureId1",
                table: "Categories",
                column: "PictureId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Pictures_PictureId1",
                table: "Categories",
                column: "PictureId1",
                principalTable: "Pictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
