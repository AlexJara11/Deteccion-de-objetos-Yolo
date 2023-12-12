using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCamYolo.Migrations
{
    public partial class HistorialStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentObjectHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ObjectId = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentObjectHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentObjectHistory_Objects_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Objects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentObjectHistory_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentObjectHistory_ObjectId",
                table: "StudentObjectHistory",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentObjectHistory_StudentId",
                table: "StudentObjectHistory",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentObjectHistory");
        }
    }
}
