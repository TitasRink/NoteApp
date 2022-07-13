using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteApp.Repository.Migrations
{
    public partial class initialFIVE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogIn");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "FirtName",
                table: "Users",
                newName: "LoginPassword");

            migrationBuilder.AddColumn<string>(
                name: "LoginName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginName",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LoginPassword",
                table: "Users",
                newName: "FirtName");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserLogIn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LoginPassword = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Token = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogIn", x => x.Id);
                });
        }
    }
}
