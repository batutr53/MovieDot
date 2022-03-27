using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDot.Repository.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Bilim Kurgu" },
                    { 3, "Aile" },
                    { 4, "Romantik" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "image.jpg", "Türkçe Dublaj" },
                    { 2, "image.jpg", "Türkçe Altyazı" },
                    { 3, "image.jpg", "Orjinal" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Moderatör" },
                    { 3, "VİP" },
                    { 4, "Üye" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "Image", "IsActive", "Password", "UserName", "UserRoleId" },
                values: new object[] { 1, new DateTime(2022, 3, 27, 22, 18, 17, 716, DateTimeKind.Local).AddTicks(2062), "batuhanturk34@gmail.com", "adminprofileimage", true, "admin", "admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "Image", "IsActive", "Password", "UserName", "UserRoleId" },
                values: new object[] { 2, new DateTime(2022, 3, 27, 22, 18, 17, 716, DateTimeKind.Local).AddTicks(2066), "info@batulab.com", "infoprofileimage", true, "info", "info", 2 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedDate", "Descr", "Image", "Imdb", "IsActive", "Time", "Title", "Url", "UserId", "Views", "Voting", "Year" },
                values: new object[] { 1, new DateTime(2022, 3, 27, 22, 18, 17, 716, DateTimeKind.Local).AddTicks(1769), "Uzay Yolcuları, Morten Tyldum tarafından yönetilen ve senaryosu Jon Spaihts tarafından yazılan 2016 yılı ABD yapımı bilimkurgu-macera filmi. Başrollerinde Chris Pratt ve Jennifer Lawrence yer almaktadır.", "https://tr.web.img3.acsta.net/pictures/16/11/17/14/42/364666.jpg", 6f, true, 155, "Uzay Yolcuları", "https://tr.web.img4.acsta.net/c_310_420/pictures/16/11/17/14/42/364666.jpg", 1, 1222, 345f, 2017 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CText", "CommentingId", "CreatedDate", "Liked", "MovieId", "UserId" },
                values: new object[] { 1, "Çok güzel bir film.", null, new DateTime(2022, 3, 27, 22, 18, 17, 716, DateTimeKind.Local).AddTicks(1206), 1234, 1, 1 });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "CategoryId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "LanguageId", "MovieId", "Name", "Url" },
                values: new object[,]
                {
                    { 1, 1, 1, "Part1 ", "https://youtu.be/8GKyQ1S5594" },
                    { 2, 2, 1, "Part2", "https://youtu.be/8GKyQ1S5594" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CText", "CommentingId", "CreatedDate", "Liked", "MovieId", "UserId" },
                values: new object[] { 2, "Çok güzel bir film. Alt Yorum.", 1, new DateTime(2022, 3, 27, 22, 18, 17, 716, DateTimeKind.Local).AddTicks(1216), 5, 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
