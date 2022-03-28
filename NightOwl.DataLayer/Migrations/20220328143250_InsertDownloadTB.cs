using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class InsertDownloadTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Download",
                columns: table => new
                {
                    DownloadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemSize = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QualityDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SeasonDetails = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    EpisodeDetails = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DownloadLink = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Download", x => x.DownloadId);
                    table.ForeignKey(
                        name: "FK_Download_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Download_ItemId",
                table: "Download",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Download");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 27, 21, 30, 11, 456, DateTimeKind.Local).AddTicks(1741));
        }
    }
}
