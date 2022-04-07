using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class addForgotPasswordToAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ForgotPassword",
                table: "Admins",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 4, 7, 16, 34, 53, 213, DateTimeKind.Local).AddTicks(6962));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForgotPassword",
                table: "Admins");

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
    }
}
