using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCamYolo.Migrations
{
    public partial class objectImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ObjectImage",
                table: "Objects",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ObjectImage",
                table: "Objects");
        }
    }
}
