using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDot.Repository.Migrations
{
    public partial class Votiss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
