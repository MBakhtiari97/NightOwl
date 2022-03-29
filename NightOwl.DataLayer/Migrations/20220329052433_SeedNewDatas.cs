using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class SeedNewDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RunningTime",
                table: "Items",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValue: "-",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RottenTomatoScore",
                table: "Items",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValue: "-",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseYear",
                table: "Items",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValue: "-",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImdbScore",
                table: "Items",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValue: "-",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Banner",
                table: "Items",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                defaultValue: "Default.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AvailableQualities",
                table: "Items",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                defaultValue: "-",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgeRating",
                table: "Items",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                defaultValue: "PG-13",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

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

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Actors", "AddedTime", "AgeRating", "AvailableQualities", "Banner", "Description", "Director", "EndRunningYear", "Episodes", "ImdbScore", "Language", "ManufacturerCountry", "MetaCriticScore", "RunningTime", "Seasons", "Title", "TrailerLink" },
                values: new object[] { 16, "Jake Gyllenhaal , Yahya Abdul - Mateen , IIEiza González", new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3778), "R", "Coming Soon", "16-Ambulance.jpg", "Two robbers steal an ambulance after their heist goes awry.", "Michael Bay", null, null, "6.5", "Eng", null, "46", "136'", null, "Ambulance", "https://www.youtube.com/embed/7NU-STboFeI" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Actors", "AddedTime", "AgeRating", "Banner", "Description", "Director", "EndRunningYear", "Episodes", "Language", "ManufacturerCountry", "MetaCriticScore", "RunningTime", "Seasons", "Title", "TrailerLink" },
                values: new object[] { 17, "Mads Mikkelsen , Ezra Miller , Katherine Waterston", new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3784), "PG-13", "17-FantasticBeastsTheSecretsOfDumbledore.jpg", "The third installment of Fantastic Beasts and Where to Find Them,which follows the continuing adventures of Newt Scamander.", "David Yates", null, null, "Eng", null, null, "142'", null, "Fantastic Beasts: The Secrets of Dumbledore", "https://www.youtube.com/embed/DaM_wL1ZOM4" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Actors", "AddedTime", "AgeRating", "Banner", "Description", "Director", "EndRunningYear", "Episodes", "Language", "ManufacturerCountry", "MetaCriticScore", "Seasons", "Title", "TrailerLink" },
                values: new object[,]
                {
                    { 18, "Mel Gibson , Mark Wahlberg , Jacki Weaver", new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3789), "R", "18-FatherStu.jpg", "Follows the life of Father Stuart Long, a boxer-turned-priest who inspired countless people during his journey from self-destruction to redemption.", "Rosalind Ross", null, null, "Eng", null, null, null, "Father Stu", "https://www.youtube.com/embed/DHREzAdyCPs" },
                    { 19, "Liam Neeson , Monica Bellucci , Ray Stevenson", new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3794), "R", "19-Memory.jpg", "An assassin-for-hire finds that he's become a target after he refuses to complete a job for a dangerous criminal organization. A remake of the 2003 Belgian film 'The Memory of a Killer", "Martin Campbell", null, null, "Eng", null, null, null, "Memory", "https://www.youtube.com/embed/6OS_LxM6y7o" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 29, 9, 54, 32, 962, DateTimeKind.Local).AddTicks(3382));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19);

            migrationBuilder.AlterColumn<string>(
                name: "RunningTime",
                table: "Items",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValue: "-");

            migrationBuilder.AlterColumn<string>(
                name: "RottenTomatoScore",
                table: "Items",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValue: "-");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseYear",
                table: "Items",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValue: "-");

            migrationBuilder.AlterColumn<string>(
                name: "ImdbScore",
                table: "Items",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValue: "-");

            migrationBuilder.AlterColumn<string>(
                name: "Banner",
                table: "Items",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true,
                oldDefaultValue: "Default.png");

            migrationBuilder.AlterColumn<string>(
                name: "AvailableQualities",
                table: "Items",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true,
                oldDefaultValue: "-");

            migrationBuilder.AlterColumn<string>(
                name: "AgeRating",
                table: "Items",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true,
                oldDefaultValue: "PG-13");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedTime",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 28, 19, 31, 33, 869, DateTimeKind.Local).AddTicks(6118));
        }
    }
}
