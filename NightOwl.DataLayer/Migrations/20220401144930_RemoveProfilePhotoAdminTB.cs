using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class RemoveProfilePhotoAdminTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminProfilePhoto",
                table: "Admins");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 19, 19, 30, 90, DateTimeKind.Local).AddTicks(5585));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminProfilePhoto",
                table: "Admins",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 4, 1, 11, 6, 31, 54, DateTimeKind.Local).AddTicks(4622));
        }
    }
}
