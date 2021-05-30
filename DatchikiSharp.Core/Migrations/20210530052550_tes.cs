using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatchikiSharp.Core.Migrations
{
    public partial class tes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "ScanerEvents",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "ScanerEvents");
        }
    }
}
