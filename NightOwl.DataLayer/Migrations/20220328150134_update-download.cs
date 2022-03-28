using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class updatedownload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6118));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 28, 19, 2, 49, 440, DateTimeKind.Local).AddTicks(7431));
        }
    }
}
