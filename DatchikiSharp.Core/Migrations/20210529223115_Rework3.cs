using Microsoft.EntityFrameworkCore.Migrations;

namespace DatchikiSharp.Core.Migrations
{
    public partial class Rework3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScanerId",
                table: "ScanerEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScanerId",
                table: "ScanerEvents");
        }
    }
}
