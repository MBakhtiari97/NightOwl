using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class updateSizeOfDownload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ItemSize",
                table: "Download",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 14, 31, 15, 321, DateTimeKind.Local).AddTicks(2485));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ItemSize",
                table: "Download",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 4, 6, 8, 8, 34, 122, DateTimeKind.Local).AddTicks(338));
        }
    }
}
