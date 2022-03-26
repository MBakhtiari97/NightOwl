using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class SeedingSomeOtherDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SelectedCategories",
                columns: new[] { "SelectedCategoryId", "CategoryId", "ItemId" },
                values: new object[,]
                {
                    { 4, 1, 1 },
                    { 5, 1, 2 },
                    { 6, 1, 3 },
                    { 7, 1, 4 },
                    { 8, 1, 5 },
                    { 9, 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "SelectedGenres",
                columns: new[] { "SelectedGenresId", "GenreId", "ItemId" },
                values: new object[,]
                {
                    { 6, 1, 1 },
                    { 7, 1, 2 },
                    { 8, 3, 2 },
                    { 9, 6, 3 },
                    { 10, 7, 3 },
                    { 11, 1, 4 },
                    { 12, 3, 4 },
                    { 13, 4, 5 },
                    { 14, 1, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 10, 12, 56, 558, DateTimeKind.Local).AddTicks(7107));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SelectedCategories",
                keyColumn: "SelectedCategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SelectedGenres",
                keyColumn: "SelectedGenresId",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 10, 2, 12, 97, DateTimeKind.Local).AddTicks(2401));
        }
    }
}
