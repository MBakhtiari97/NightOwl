using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class UpdateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVIP",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RemainingVipSubscription",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 29, 12, 21, 44, 881, DateTimeKind.Local).AddTicks(2630));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVIP",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RemainingVipSubscription",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedTime",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3382));
        }
    }
}
