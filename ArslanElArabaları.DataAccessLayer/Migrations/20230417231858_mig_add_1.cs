using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArslanElArabaları.DataAccessLayer.Migrations
{
    public partial class mig_add_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_WriterID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_WriterID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Posts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostCreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostCreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_WriterID",
                table: "Posts",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_WriterID",
                table: "Posts",
                column: "WriterID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
