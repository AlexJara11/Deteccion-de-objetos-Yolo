using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCamYolo.Migrations
{
    public partial class NuevaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                schema: "dbo",
                table: "StudentObjectHistory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "StudentObjectHistory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
