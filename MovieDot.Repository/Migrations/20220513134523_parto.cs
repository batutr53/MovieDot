using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDot.Repository.Migrations
{
    public partial class parto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 40, 13, 124, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 16, 40, 13, 124, DateTimeKind.Local).AddTicks(7534));
        }
    }
}
