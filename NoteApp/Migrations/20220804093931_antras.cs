using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteApp.Repository.Migrations
{
    public partial class antras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Categories");
        }
    }
}
