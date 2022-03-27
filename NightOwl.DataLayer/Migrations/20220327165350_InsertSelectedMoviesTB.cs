using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class InsertSelectedMoviesTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Items_ItemId",
                table: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Actors_ItemId",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Actors");

            migrationBuilder.AddColumn<int>(
                name: "ItemsItemId",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SelectedMovies",
                columns: table => new
                {
                    SelectedMovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedMovies", x => x.SelectedMovieId);
                    table.ForeignKey(
                        name: "FK_SelectedMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedMovies_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorGender", "ActorImage", "ActorName", "ItemsItemId" },
                values: new object[,]
                {
                    { 1, "Male", "Aaron Paul.jpg", "Aaron Paul", null },
                    { 2, "Male", "Benedict Cumberbatch.jpg", "Benedict Cumberbatch", null },
                    { 3, "Male", "Mark Ruffalo.jpg", "Mark Ruffalo", null },
                    { 4, "Male", "Ryan Reynolds.jpg", "Ryan Reynolds", null },
                    { 5, "Female", "Ana De Armas.jpg", "Ana De Armas", null },
                    { 6, "Female", "Zendaya.jpg", "Zendaya", null }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 27, 21, 23, 50, 256, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.CreateIndex(
                name: "IX_Actors_ItemsItemId",
                table: "Actors",
                column: "ItemsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedMovies_ActorId",
                table: "SelectedMovies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedMovies_ItemId",
                table: "SelectedMovies",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Items_ItemsItemId",
                table: "Actors",
                column: "ItemsItemId",
                principalTable: "Items",
                principalColumn: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Items_ItemsItemId",
                table: "Actors");

            migrationBuilder.DropTable(
                name: "SelectedMovies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_ItemsItemId",
                table: "Actors");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "ItemsItemId",
                table: "Actors");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Actors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 27, 21, 3, 44, 946, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.CreateIndex(
                name: "IX_Actors_ItemId",
                table: "Actors",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Items_ItemId",
                table: "Actors",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
