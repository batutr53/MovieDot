using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDot.Repository.Migrations
{
    public partial class back : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieVotings");

            migrationBuilder.DropTable(
                name: "Votings");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 43, 44, 497, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 43, 44, 497, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 43, 44, 497, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 43, 44, 497, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 43, 44, 497, DateTimeKind.Local).AddTicks(1996));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Votings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Vote = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieVotings",
                columns: table => new
                {
                    VotingId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
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
                value: new DateTime(2022, 4, 10, 15, 29, 21, 373, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 29, 21, 373, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 29, 21, 373, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 29, 21, 373, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 10, 15, 29, 21, 373, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.CreateIndex(
                name: "IX_MovieVotings_MovieId",
                table: "MovieVotings",
                column: "MovieId");
        }
    }
}
