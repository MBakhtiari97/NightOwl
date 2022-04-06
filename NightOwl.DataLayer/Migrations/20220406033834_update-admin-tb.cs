using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class updateadmintb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Galleries",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<bool>(
                name: "IsModerator",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsModerator",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Galleries",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

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
    }
}
