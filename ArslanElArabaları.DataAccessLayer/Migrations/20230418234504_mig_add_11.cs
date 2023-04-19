using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArslanElArabaları.DataAccessLayer.Migrations
{
    public partial class mig_add_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostThumbnailImage",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostThumbnailImage",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
