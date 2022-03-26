using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class initSeedingSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndRunningYear",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Episodes",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Seasons",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Actors", "AddedTime", "AgeRating", "AvailableQualities", "Banner", "Description", "Director", "EndRunningYear", "Episodes", "ImdbScore", "Language", "ManufacturerCountry", "MetaCriticScore", "ReleaseYear", "RottenTomatoScore", "RunningTime", "Seasons", "Title" },
                values: new object[,]
                {
                    { 12, "Alexander Dreymon , Eliza Butterworth , Arnas Fedaravicius", new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1074), "TV-MA", "480p,720p,1080p", "12-TheLastKingdom.jpg", "As Alfred the Great defends his kingdom from Norse invaders, Uhtred--born a Saxon but raised by Vikings--seeks to claim his ancestral birthright.", "Jon East , Edward Bazalgette , Peter Hoar , Alexander Dreymon , Sarah O'Gorman", "-", 46, "8.5", "Eng", null, null, "2015", null, "60'", 5, "The Last Kingdom" },
                    { 13, "Cillian Murphy , Paul Anderson , Sophie Rundle", new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1080), "TV-MA", "480p,720p,1080p", "13-PeakyBlinders.jpg", "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.", "Steven Knight", "-", 36, "8.8", "Eng", null, null, "2013", null, "60'", 6, "Peaky Blinders" },
                    { 14, "Emilia Clarke , Peter Dinklage , Kit Harington", new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1084), "TV-MA", "480p,720p,1080p", "14-GameofThrones.jpg", "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", "David Benioff , D.B.Weiss", "2019", 73, "9.3", "Eng", null, null, "2011", null, "57'", 8, "Game of Thrones" },
                    { 15, "Bryan Cranston , Aaron Paul , Anna Gunn", new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1088), "TV-MA", "480p,720p,1080p", "15-BreakingBad.jpg", "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "Vince Gilligan", "2013", 62, "9.5", "Eng", null, null, "2008", null, "49'", 5, "Breaking Bad" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.InsertData(
                table: "SelectedCategories",
                columns: new[] { "SelectedCategoryId", "CategoryId", "ItemId" },
                values: new object[,]
                {
                    { 10, 2, 12 },
                    { 11, 2, 13 },
                    { 12, 2, 14 },
                    { 13, 2, 15 }
                });

            migrationBuilder.InsertData(
                table: "SelectedGenres",
                columns: new[] { "SelectedGenresId", "GenreId", "ItemId" },
                values: new object[,]
                {
                    { 15, 1, 12 },
                    { 16, 4, 12 },
                    { 17, 5, 12 },
                    { 18, 1, 13 },
                    { 19, 4, 13 },
                    { 20, 1, 14 },
                    { 21, 4, 14 },
                    { 22, 5, 14 },
                    { 23, 1, 15 },
                    { 24, 4, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "EndRunningYear",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Episodes",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Seasons",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 10, 15, 40, 401, DateTimeKind.Local).AddTicks(9865));
        }
    }
}
