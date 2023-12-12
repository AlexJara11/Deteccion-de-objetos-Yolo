using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCamYolo.Migrations
{
    public partial class Definitiva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentObjectHistory_Objects_ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.DropIndex(
                name: "IX_StudentObjectHistory_ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.DropColumn(
                name: "ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentObjectHistory_ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory",
                column: "ObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentObjectHistory_Objects_ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory",
                column: "ObjectId",
                principalTable: "Objects",
                principalColumn: "Id");
        }
    }
}
