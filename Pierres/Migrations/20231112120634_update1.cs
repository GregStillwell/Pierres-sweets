using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pierres.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors");

            migrationBuilder.DropForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Treats_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Flavors_UserId",
                table: "Flavors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Flavors");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Treats",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Flavors",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Treats_UserId",
                table: "Treats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Flavors_UserId",
                table: "Flavors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
