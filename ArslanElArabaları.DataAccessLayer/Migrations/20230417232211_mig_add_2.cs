using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArslanElArabaları.DataAccessLayer.Migrations
{
    public partial class mig_add_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AdminUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AdminUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "AdminUserId",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminUserId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AdminUserId",
                table: "Posts",
                column: "AdminUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AdminUserId",
                table: "Posts",
                column: "AdminUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
