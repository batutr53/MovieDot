using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDot.Repository.Migrations
{
    public partial class partos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 47, 37, 874, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 47, 37, 874, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 47, 37, 874, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 47, 37, 874, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 47, 37, 874, DateTimeKind.Local).AddTicks(4494));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 16, 45, 22, 508, DateTimeKind.Local).AddTicks(6027), new DateTime(2022, 5, 13, 16, 45, 22, 508, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 16, 45, 22, 508, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 5, 13, 16, 45, 22, 508, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 16, 45, 22, 508, DateTimeKind.Local).AddTicks(6661), new DateTime(2022, 5, 13, 16, 45, 22, 508, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 45, 22, 508, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 45, 22, 508, DateTimeKind.Local).AddTicks(7054));
        }
    }
}
