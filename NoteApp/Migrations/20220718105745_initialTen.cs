using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteApp.Repository.Migrations
{
    public partial class initialTen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Categories_CategorieId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CategorieId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorieId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CategorieId",
                table: "Users",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Categories_CategorieId",
                table: "Users",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
