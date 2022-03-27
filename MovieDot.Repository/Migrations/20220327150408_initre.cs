using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDot.Repository.Migrations
{
    public partial class initre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Like",
                table: "Comments",
                newName: "Liked");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Liked",
                table: "Comments",
                newName: "Like");
        }
    }
}
