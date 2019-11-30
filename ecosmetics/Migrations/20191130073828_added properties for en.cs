using Microsoft.EntityFrameworkCore.Migrations;

namespace ecosmetics.Migrations
{
    public partial class addedpropertiesforen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentEn",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ContentEn",
                table: "Articles");
        }
    }
}
