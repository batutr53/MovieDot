using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDot.Repository.Migrations
{
    public partial class comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Comments",
                newName: "CommentingId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentingId",
                table: "Comments",
                column: "CommentingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_CommentingId",
                table: "Comments",
                column: "CommentingId",
                principalTable: "Comments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_CommentingId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentingId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommentingId",
                table: "Comments",
                newName: "CommentId");
        }
    }
}
