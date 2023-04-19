using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArslanElArabaları.DataAccessLayer.Migrations
{
    public partial class mid_add_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostContent",
                table: "Posts");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "PostContent",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
