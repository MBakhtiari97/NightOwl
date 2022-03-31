using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class updatrviwtb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewRating",
                table: "Reviews",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 3, 31, 14, 53, 52, 275, DateTimeKind.Local).AddTicks(3732));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ReviewRating",
                table: "Reviews",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 3, 30, 12, 19, 0, 383, DateTimeKind.Local).AddTicks(5687));
        }
    }
}
