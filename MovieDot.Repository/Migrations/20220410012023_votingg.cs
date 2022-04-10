using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDot.Repository.Migrations
{
    public partial class votingg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Voting",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "Votings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vote = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieVotings",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    VotingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieVotings", x => new { x.VotingId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieVotings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieVotings_Votings_VotingId",
                        column: x => x.VotingId,
                        principalTable: "Votings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 4, 20, 22, 602, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 4, 20, 22, 602, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 4, 20, 22, 602, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 4, 20, 22, 602, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 4, 20, 22, 602, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.CreateIndex(
                name: "IX_MovieVotings_MovieId",
                table: "MovieVotings",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieVotings");

            migrationBuilder.DropTable(
                name: "Votings");

            migrationBuilder.AddColumn<double>(
                name: "Voting",
                table: "Movies",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 9, 17, 54, 7, 944, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 9, 17, 54, 7, 944, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Voting" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 54, 7, 944, DateTimeKind.Local).AddTicks(3217), 345.0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 9, 17, 54, 7, 944, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 9, 17, 54, 7, 944, DateTimeKind.Local).AddTicks(3507));
        }
    }
}
