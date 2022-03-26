﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NightOwl.DataLayer.Context;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    [DbContext(typeof(NightOwlContext))]
    partial class NightOwlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Movie"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "TvSeries"
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Galleries", b =>
                {
                    b.Property<int>("GalleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GalleryId"), 1L, 1);

                    b.Property<string>("ImageAltName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("GalleryId");

                    b.HasIndex("ItemId");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Genres", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Action"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Horror"
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "Exciting"
                        },
                        new
                        {
                            GenreId = 4,
                            GenreName = "Drama"
                        },
                        new
                        {
                            GenreId = 5,
                            GenreName = "History"
                        },
                        new
                        {
                            GenreId = 6,
                            GenreName = "Family"
                        },
                        new
                        {
                            GenreId = 7,
                            GenreName = "Animation"
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Items", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<string>("Actors")
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<DateTime?>("AddedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("AgeRating")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("AvailableQualities")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Banner")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("Director")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("EndRunningYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Episodes")
                        .HasColumnType("int");

                    b.Property<string>("ImdbScore")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Language")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ManufacturerCountry")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MetaCriticScore")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ReleaseYear")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("RottenTomatoScore")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RunningTime")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("Seasons")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TrailerLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Actors = "Robert Pattinson , Zoë Kravitz , Jeffrey Wright",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8185),
                            AgeRating = "PG-13",
                            AvailableQualities = "4K,1080p,720p",
                            Banner = "1-TheBatman.jpg",
                            Description = "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.",
                            Director = "Matt Reeves",
                            ImdbScore = "8.4",
                            Language = "Eng",
                            ManufacturerCountry = "USA",
                            MetaCriticScore = "72",
                            ReleaseYear = "2022",
                            RunningTime = "176'",
                            Title = "The Batman",
                            TrailerLink = "https://www.youtube.com/embed/mqqft2x_Aa4"
                        },
                        new
                        {
                            ItemId = 2,
                            Actors = "Ryan Reynolds , Walker Scobell , Mark Ruffalo",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8193),
                            AgeRating = "PG-13",
                            AvailableQualities = "4K,1080p,720p",
                            Banner = "2-TheAdamProject.jpg",
                            Description = "After accidentally crash-landing in 2022, time-traveling fighter pilot Adam Reed teams up with his 12-year-old self for a mission to save the future.",
                            Director = "Shawn Levy",
                            ImdbScore = "6.8",
                            Language = "Eng",
                            MetaCriticScore = "55",
                            ReleaseYear = "2022",
                            RunningTime = "106'",
                            Title = "The Adam Project",
                            TrailerLink = "https://www.youtube.com/embed/IE8HIsIrq4o"
                        },
                        new
                        {
                            ItemId = 3,
                            Actors = "Rosalie Chiang , Sandra Oh , Ava Morse",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8197),
                            AgeRating = "PG",
                            AvailableQualities = "4K,1080p,720p",
                            Banner = "3-TurningRed.jpg",
                            Description = "A 13-year-old girl named Meilin turns into a giant red panda whenever she gets too excited.",
                            Director = "Domee Shi",
                            ImdbScore = "7.1",
                            Language = "Eng",
                            MetaCriticScore = "83",
                            ReleaseYear = "2022",
                            RunningTime = "100'",
                            Title = "Turning Red",
                            TrailerLink = "https://www.youtube.com/embed/XdKzUbAiswE"
                        },
                        new
                        {
                            ItemId = 4,
                            Actors = "Tom Holland , Zendaya , Benedict Cumberbatch",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8201),
                            AgeRating = "PG-13",
                            AvailableQualities = "4K,1080p,720p",
                            Banner = "4-Spider-Man:NoWayHome.jpg",
                            Description = "With Spider-Man's identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear, forcing Peter to discover what it truly means to be Spider-Man.",
                            Director = "Jon Watts",
                            ImdbScore = "8.5",
                            Language = "Eng",
                            MetaCriticScore = "71",
                            ReleaseYear = "2021",
                            RunningTime = "148'",
                            Title = "Spider-Man: No Way Home",
                            TrailerLink = "https://www.youtube.com/embed/JfVOs4VSpmA"
                        },
                        new
                        {
                            ItemId = 5,
                            Actors = "Ben Affleck , Ana de Armas , Tracy Letts",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8205),
                            AgeRating = "R",
                            AvailableQualities = "4K,1080p,720p",
                            Banner = "5-DeepWater.jpg",
                            Description = "A well-to-do husband who allows his wife to have affairs in order to avoid a divorce becomes a prime suspect in the disappearance of her lovers.",
                            Director = "Adrian Lyne",
                            ImdbScore = "5.4",
                            Language = "Eng",
                            MetaCriticScore = "52",
                            ReleaseYear = "2022",
                            RunningTime = "115'",
                            Title = "Deep Water",
                            TrailerLink = "https://www.youtube.com/embed/h0zqe_As_qo"
                        },
                        new
                        {
                            ItemId = 6,
                            Actors = "Timothée Chalamet , Rebecca Ferguson , Zendaya",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8209),
                            AgeRating = "PG-13",
                            AvailableQualities = "4K,1080p,720p",
                            Banner = "6-Dune.jpg",
                            Description = "A noble family becomes embroiled in a war for control over the galaxy's most valuable asset while its scion becomes troubled by visions of a dark future.",
                            Director = "Denis Villeneuve",
                            ImdbScore = "8.1",
                            Language = "Eng",
                            MetaCriticScore = "74",
                            ReleaseYear = "2021",
                            RunningTime = "155'",
                            Title = "Dune",
                            TrailerLink = "https://www.youtube.com/embed/8g18jFHCLXk"
                        },
                        new
                        {
                            ItemId = 12,
                            Actors = "Alexander Dreymon , Eliza Butterworth , Arnas Fedaravicius",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8227),
                            AgeRating = "TV-MA",
                            AvailableQualities = "480p,720p,1080p",
                            Banner = "12-TheLastKingdom.jpg",
                            Description = "As Alfred the Great defends his kingdom from Norse invaders, Uhtred--born a Saxon but raised by Vikings--seeks to claim his ancestral birthright.",
                            Director = "Jon East , Edward Bazalgette , Peter Hoar , Alexander Dreymon , Sarah O'Gorman",
                            EndRunningYear = "-",
                            Episodes = 46,
                            ImdbScore = "8.5",
                            Language = "Eng",
                            ReleaseYear = "2015",
                            RunningTime = "60'",
                            Seasons = 5,
                            Title = "The Last Kingdom",
                            TrailerLink = "https://www.youtube.com/embed/NNBNX34mO34"
                        },
                        new
                        {
                            ItemId = 13,
                            Actors = "Cillian Murphy , Paul Anderson , Sophie Rundle",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8232),
                            AgeRating = "TV-MA",
                            AvailableQualities = "480p,720p,1080p",
                            Banner = "13-PeakyBlinders.jpg",
                            Description = "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.",
                            Director = "Steven Knight",
                            EndRunningYear = "-",
                            Episodes = 36,
                            ImdbScore = "8.8",
                            Language = "Eng",
                            ReleaseYear = "2013",
                            RunningTime = "60'",
                            Seasons = 6,
                            Title = "Peaky Blinders",
                            TrailerLink = "https://www.youtube.com/embed/2nsT9uQPIrk"
                        },
                        new
                        {
                            ItemId = 14,
                            Actors = "Emilia Clarke , Peter Dinklage , Kit Harington",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8236),
                            AgeRating = "TV-MA",
                            AvailableQualities = "480p,720p,1080p",
                            Banner = "14-GameofThrones.jpg",
                            Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                            Director = "David Benioff , D.B.Weiss",
                            EndRunningYear = "2019",
                            Episodes = 73,
                            ImdbScore = "9.3",
                            Language = "Eng",
                            ReleaseYear = "2011",
                            RunningTime = "57'",
                            Seasons = 8,
                            Title = "Game of Thrones",
                            TrailerLink = "https://www.youtube.com/embed/KPLWWIOCOOQ"
                        },
                        new
                        {
                            ItemId = 15,
                            Actors = "Bryan Cranston , Aaron Paul , Anna Gunn",
                            AddedTime = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(8240),
                            AgeRating = "TV-MA",
                            AvailableQualities = "480p,720p,1080p",
                            Banner = "15-BreakingBad.jpg",
                            Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                            Director = "Vince Gilligan",
                            EndRunningYear = "2013",
                            Episodes = 62,
                            ImdbScore = "9.5",
                            Language = "Eng",
                            ReleaseYear = "2008",
                            RunningTime = "49'",
                            Seasons = 5,
                            Title = "Breaking Bad",
                            TrailerLink = "https://www.youtube.com/embed/HhesaQXLuRY"
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.SelectedCategory", b =>
                {
                    b.Property<int>("SelectedCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedCategoryId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("SelectedCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ItemId");

                    b.ToTable("SelectedCategories");

                    b.HasData(
                        new
                        {
                            SelectedCategoryId = 4,
                            CategoryId = 1,
                            ItemId = 1
                        },
                        new
                        {
                            SelectedCategoryId = 5,
                            CategoryId = 1,
                            ItemId = 2
                        },
                        new
                        {
                            SelectedCategoryId = 6,
                            CategoryId = 1,
                            ItemId = 3
                        },
                        new
                        {
                            SelectedCategoryId = 7,
                            CategoryId = 1,
                            ItemId = 4
                        },
                        new
                        {
                            SelectedCategoryId = 8,
                            CategoryId = 1,
                            ItemId = 5
                        },
                        new
                        {
                            SelectedCategoryId = 9,
                            CategoryId = 1,
                            ItemId = 6
                        },
                        new
                        {
                            SelectedCategoryId = 10,
                            CategoryId = 2,
                            ItemId = 12
                        },
                        new
                        {
                            SelectedCategoryId = 11,
                            CategoryId = 2,
                            ItemId = 13
                        },
                        new
                        {
                            SelectedCategoryId = 12,
                            CategoryId = 2,
                            ItemId = 14
                        },
                        new
                        {
                            SelectedCategoryId = 13,
                            CategoryId = 2,
                            ItemId = 15
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.SelectedGenres", b =>
                {
                    b.Property<int>("SelectedGenresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedGenresId"), 1L, 1);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("SelectedGenresId");

                    b.HasIndex("GenreId");

                    b.HasIndex("ItemId");

                    b.ToTable("SelectedGenres");

                    b.HasData(
                        new
                        {
                            SelectedGenresId = 6,
                            GenreId = 1,
                            ItemId = 1
                        },
                        new
                        {
                            SelectedGenresId = 7,
                            GenreId = 1,
                            ItemId = 2
                        },
                        new
                        {
                            SelectedGenresId = 8,
                            GenreId = 3,
                            ItemId = 2
                        },
                        new
                        {
                            SelectedGenresId = 9,
                            GenreId = 6,
                            ItemId = 3
                        },
                        new
                        {
                            SelectedGenresId = 10,
                            GenreId = 7,
                            ItemId = 3
                        },
                        new
                        {
                            SelectedGenresId = 11,
                            GenreId = 1,
                            ItemId = 4
                        },
                        new
                        {
                            SelectedGenresId = 12,
                            GenreId = 3,
                            ItemId = 4
                        },
                        new
                        {
                            SelectedGenresId = 13,
                            GenreId = 4,
                            ItemId = 5
                        },
                        new
                        {
                            SelectedGenresId = 14,
                            GenreId = 1,
                            ItemId = 6
                        },
                        new
                        {
                            SelectedGenresId = 15,
                            GenreId = 1,
                            ItemId = 12
                        },
                        new
                        {
                            SelectedGenresId = 16,
                            GenreId = 4,
                            ItemId = 12
                        },
                        new
                        {
                            SelectedGenresId = 17,
                            GenreId = 5,
                            ItemId = 12
                        },
                        new
                        {
                            SelectedGenresId = 18,
                            GenreId = 1,
                            ItemId = 13
                        },
                        new
                        {
                            SelectedGenresId = 19,
                            GenreId = 4,
                            ItemId = 13
                        },
                        new
                        {
                            SelectedGenresId = 20,
                            GenreId = 1,
                            ItemId = 14
                        },
                        new
                        {
                            SelectedGenresId = 21,
                            GenreId = 4,
                            ItemId = 14
                        },
                        new
                        {
                            SelectedGenresId = 22,
                            GenreId = 5,
                            ItemId = 14
                        },
                        new
                        {
                            SelectedGenresId = 23,
                            GenreId = 1,
                            ItemId = 15
                        },
                        new
                        {
                            SelectedGenresId = 24,
                            GenreId = 4,
                            ItemId = 15
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("WalletId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            EmailAddress = "pzix886@gmail.com",
                            IpAddress = "192.168.1.127",
                            Password = "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70",
                            PhoneNumber = "09121111111",
                            RegisterDate = new DateTime(2022, 3, 26, 14, 5, 5, 65, DateTimeKind.Local).AddTicks(7930),
                            RoleId = 2,
                            Username = "Admin",
                            WalletId = 1
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.WalletTransactions", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WalletId"), 1L, 1);

                    b.Property<int?>("DepositValue")
                        .HasColumnType("int");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WalletBalance")
                        .HasColumnType("int");

                    b.Property<int?>("WithdrawalValue")
                        .HasColumnType("int");

                    b.HasKey("WalletId");

                    b.HasIndex("UserId");

                    b.ToTable("WalletTransactions");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Galleries", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Items", "Items")
                        .WithMany("Galleries")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Items");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Roles", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Users", "Users")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.SelectedCategory", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Categories", "Categories")
                        .WithMany("SelectedCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NightOwl.DataLayer.Entities.Items", "Items")
                        .WithMany("SelectedCategory")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.SelectedGenres", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Genres", "Genres")
                        .WithMany("SelectedGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NightOwl.DataLayer.Entities.Items", "Items")
                        .WithMany("SelectedGenres")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.WalletTransactions", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Users", "Users")
                        .WithMany("WalletTransactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Categories", b =>
                {
                    b.Navigation("SelectedCategory");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Genres", b =>
                {
                    b.Navigation("SelectedGenres");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Items", b =>
                {
                    b.Navigation("Galleries");

                    b.Navigation("SelectedCategory");

                    b.Navigation("SelectedGenres");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Users", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("WalletTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
