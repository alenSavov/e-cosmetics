﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace e_cosmetics.Migrations
{
    public partial class Removedpicturefromcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Pictures_PictureId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PictureId",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "PictureId",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
