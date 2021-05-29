using Microsoft.EntityFrameworkCore.Migrations;

namespace DatchikiSharp.Core.Migrations
{
    public partial class Rework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activity",
                table: "Scaners",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Scaners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Scaners",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Rooms",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Scaners_RoomId",
                table: "Scaners",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scaners_Rooms_RoomId",
                table: "Scaners",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scaners_Rooms_RoomId",
                table: "Scaners");

            migrationBuilder.DropIndex(
                name: "IX_Scaners_RoomId",
                table: "Scaners");

            migrationBuilder.DropColumn(
                name: "Activity",
                table: "Scaners");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Scaners");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Scaners");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rooms");
        }
    }
}
