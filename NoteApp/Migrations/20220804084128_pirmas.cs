using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteApp.Repository.Migrations
{
    public partial class pirmas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Notes");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Byte = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NoteModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Notes_NoteModelId",
                        column: x => x.NoteModelId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_NoteModelId",
                table: "Images",
                column: "NoteModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Notes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }
    }
}
