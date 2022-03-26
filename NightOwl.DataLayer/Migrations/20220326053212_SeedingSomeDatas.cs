using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class SeedingSomeDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Actors", "AgeRating", "AvailableQualities", "Banner", "Description", "Director", "ImdbScore", "Language", "ManufacturerCountry", "MetaCriticScore", "ReleaseYear", "RottenTomatoScore", "RunningTime", "Title" },
                values: new object[,]
                {
                    { 1, "Robert Pattinson , Zoë Kravitz , Jeffrey Wright", "PG-13", "4K,1080p,720p", "1-TheBatman.jpg", "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.", "Matt Reeves", "8.4", "Eng", "USA", "72", "2022", null, "176'", "The Batman" },
                    { 2, "Ryan Reynolds , Walker Scobell , Mark Ruffalo", "PG-13", "4K,1080p,720p", "2-TheAdamProject.jpg", "After accidentally crash-landing in 2022, time-traveling fighter pilot Adam Reed teams up with his 12-year-old self for a mission to save the future.", "Shawn Levy", "6.8", "Eng", null, "55", "2022", null, "106'", "The Adam Project" },
                    { 3, "Rosalie Chiang , Sandra Oh , Ava Morse", "PG", "4K,1080p,720p", "3-TurningRed.jpg", "A 13-year-old girl named Meilin turns into a giant red panda whenever she gets too excited.", "Domee Shi", "7.1", "Eng", null, "83", "2022", null, "100'", "Turning Red" },
                    { 4, "Tom Holland , Zendaya , Benedict Cumberbatch", "PG-13", "4K,1080p,720p", "4-Spider-Man:NoWayHome.jpg", "With Spider-Man's identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear, forcing Peter to discover what it truly means to be Spider-Man.", "Jon Watts", "8.5", "Eng", null, "71", "2021", null, "148'", "Spider-Man: No Way Home" },
                    { 5, "Ben Affleck , Ana de Armas , Tracy Letts", "R", "4K,1080p,720p", "5-DeepWater.jpg", "A well-to-do husband who allows his wife to have affairs in order to avoid a divorce becomes a prime suspect in the disappearance of her lovers.", "Adrian Lyne", "5.4", "Eng", null, "52", "2022", null, "115'", "Deep Water" },
                    { 6, "Timothée Chalamet , Rebecca Ferguson , Zendaya", "PG-13", "4K,1080p,720p", "6-Dune.jpg", "A noble family becomes embroiled in a war for control over the galaxy's most valuable asset while its scion becomes troubled by visions of a dark future.", "Denis Villeneuve", "8.1", "Eng", null, "74", "2021", null, "155'", "Dune" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 10, 2, 12, 97, DateTimeKind.Local).AddTicks(2401));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 3, 26, 6, 41, 39, 873, DateTimeKind.Local).AddTicks(4716));
        }
    }
}
