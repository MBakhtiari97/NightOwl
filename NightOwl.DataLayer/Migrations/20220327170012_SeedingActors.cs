using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class SeedingActors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.InsertData(
                table: "SelectedMovies",
                columns: new[] { "SelectedMovieId", "ActorId", "ItemId" },
                values: new object[,]
                {
                    { 1, 1, 15 },
                    { 2, 2, 4 },
                    { 3, 3, 2 },
                    { 4, 4, 2 },
                    { 5, 5, 5 },
                    { 6, 6, 4 },
                    { 7, 6, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(1741));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SelectedMovies",
                keyColumn: "SelectedMovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SelectedMovies",
                keyColumn: "SelectedMovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SelectedMovies",
                keyColumn: "SelectedMovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SelectedMovies",
                keyColumn: "SelectedMovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SelectedMovies",
                keyColumn: "SelectedMovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SelectedMovies",
                keyColumn: "SelectedMovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SelectedMovies",
                keyColumn: "SelectedMovieId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3608));
        }
    }
}
