using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class changedentityName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CategoryPictures");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "CategoryPictures",
                nullable: true);
        }
    }
}
