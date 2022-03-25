using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    ReleaseYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ManufacturerCountry = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Language = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ImdbScore = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RottenTomatoScore = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MetaCriticScore = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AvailableQualities = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RunningTime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Banner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Actors = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    Director = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    WalletId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "SelectedCategories",
                columns: table => new
                {
                    SelectedCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedCategories", x => x.SelectedCategoryId);
                    table.ForeignKey(
                        name: "FK_SelectedCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedCategories_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedGenres",
                columns: table => new
                {
                    SelectedGenresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedGenres", x => x.SelectedGenresId);
                    table.ForeignKey(
                        name: "FK_SelectedGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedGenres_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Roles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WalletTransactions",
                columns: table => new
                {
                    WalletId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletBalance = table.Column<int>(type: "int", nullable: false),
                    DepositValue = table.Column<int>(type: "int", nullable: true),
                    WithdrawalValue = table.Column<int>(type: "int", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletTransactions", x => x.WalletId);
                    table.ForeignKey(
                        name: "FK_WalletTransactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "ItemId" },
                values: new object[,]
                {
                    { 1, "فیلم", 0 },
                    { 2, "سریال", 0 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName", "ItemId" },
                values: new object[,]
                {
                    { 1, "اکشن", 0 },
                    { 2, "ترسناک", 0 },
                    { 3, "مهیج", 0 },
                    { 4, "درام", 0 },
                    { 5, "تاریخی", 0 },
                    { 6, "خانوادگی", 0 },
                    { 7, "انیمیشن", 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "EmailAddress", "IpAddress", "Password", "PhoneNumber", "RegisterDate", "RoleId", "Username", "WalletId" },
                values: new object[] { 1, "pzix886@gmail.com", "192.168.1.127", "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", "09121111111", new DateTime(2022, 3, 25, 14, 18, 54, 694, DateTimeKind.Local).AddTicks(7514), 2, "ادمین سیستم", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedCategories_CategoryId",
                table: "SelectedCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedCategories_ItemId",
                table: "SelectedCategories",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedGenres_GenreId",
                table: "SelectedGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedGenres_ItemId",
                table: "SelectedGenres",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletTransactions_UserId",
                table: "WalletTransactions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SelectedCategories");

            migrationBuilder.DropTable(
                name: "SelectedGenres");

            migrationBuilder.DropTable(
                name: "WalletTransactions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
