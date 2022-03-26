using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class updateItemTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrailerLink",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3669), "https://youtu.be/mqqft2x_Aa4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3679), "https://youtu.be/IE8HIsIrq4o" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3682), "https://youtu.be/XdKzUbAiswE" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3686), "https://youtu.be/JfVOs4VSpmA" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3689), "https://youtu.be/h0zqe_As_qo" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3692), "https://youtu.be/8g18jFHCLXk" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3708), "https://youtu.be/NNBNX34mO34" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3713), "https://youtu.be/2nsT9uQPIrk" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3717), "https://youtu.be/KPLWWIOCOOQ" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3721), "https://youtu.be/HhesaQXLuRY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 13, 42, 42, 356, DateTimeKind.Local).AddTicks(3456));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrailerLink",
                table: "Items");

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

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 11, 47, 35, 572, DateTimeKind.Local).AddTicks(816));
        }
    }
}
