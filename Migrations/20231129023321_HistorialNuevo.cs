using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCamYolo.Migrations
{
    public partial class HistorialNuevo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentObjectHistory",
                table: "StudentObjectHistory");

            migrationBuilder.DropIndex(
                name: "IX_StudentObjectHistory_StudentId",
                table: "StudentObjectHistory");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "StudentObjectHistory",
                newName: "StudentObjectHistory",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFin",
                schema: "dbo",
                table: "StudentObjectHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TiempoUso",
                schema: "dbo",
                table: "StudentObjectHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentObjectHistory",
                schema: "dbo",
                table: "StudentObjectHistory",
                columns: new[] { "StudentId", "ObjectId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentObjectHistory",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.DropColumn(
                name: "TiempoUso",
                schema: "dbo",
                table: "StudentObjectHistory");

            migrationBuilder.RenameTable(
                name: "StudentObjectHistory",
                schema: "dbo",
                newName: "StudentObjectHistory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFin",
                table: "StudentObjectHistory",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentObjectHistory",
                table: "StudentObjectHistory",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentObjectHistory_StudentId",
                table: "StudentObjectHistory",
                column: "StudentId");
        }
    }
}
