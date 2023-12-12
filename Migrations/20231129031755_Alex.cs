using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCamYolo.Migrations
{
    public partial class Alex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentObjectHistory_Objects_ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentObjectHistory",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.AlterColumn<int>(
                name: "ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "StudentObjectHistory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentObjectHistory",
                schema: "dbo",
                table: "StudentObjectHistory",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentObjectHistory_StudentId",
                schema: "dbo",
                table: "StudentObjectHistory",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentObjectHistory_Objects_ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory",
                column: "ObjectId",
                principalTable: "Objects",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentObjectHistory_Objects_ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentObjectHistory",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.DropIndex(
                name: "IX_StudentObjectHistory_StudentId",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.AlterColumn<int>(
                name: "ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentObjectHistory",
                schema: "dbo",
                table: "StudentObjectHistory",
                columns: new[] { "StudentId", "ObjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentObjectHistory_Objects_ObjectId",
                schema: "dbo",
                table: "StudentObjectHistory",
                column: "ObjectId",
                principalTable: "Objects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
