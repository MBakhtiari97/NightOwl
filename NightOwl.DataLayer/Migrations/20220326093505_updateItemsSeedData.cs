using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class updateItemsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8185), "https://www.youtube.com/embed/mqqft2x_Aa4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8193), "https://www.youtube.com/embed/IE8HIsIrq4o" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8197), "https://www.youtube.com/embed/XdKzUbAiswE" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8201), "https://www.youtube.com/embed/JfVOs4VSpmA" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8205), "https://www.youtube.com/embed/h0zqe_As_qo" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8209), "https://www.youtube.com/embed/8g18jFHCLXk" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8227), "https://www.youtube.com/embed/NNBNX34mO34" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8232), "https://www.youtube.com/embed/2nsT9uQPIrk" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8236), "https://www.youtube.com/embed/KPLWWIOCOOQ" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                columns: new[] { "AddedTime", "TrailerLink" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8240), "https://www.youtube.com/embed/HhesaQXLuRY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(7930));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
