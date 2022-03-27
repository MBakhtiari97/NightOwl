using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NightOwl.DataLayer.Entities;
using NightOwl.Utility.Security;

namespace NightOwl.DataLayer.Context
{
    public class NightOwlContext : DbContext
    {
        public NightOwlContext(DbContextOptions<NightOwlContext> options) : base(options)
        {

        }

        #region Entities
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<WalletTransactions> WalletTransactions { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<SelectedGenres> SelectedGenres { get; set; }
        public DbSet<SelectedCategory> SelectedCategories { get; set; }
        public DbSet<Galleries> Galleries { get; set; }
        public DbSet<Actors> Actors { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region SeedData

            #region Users

            modelBuilder.Entity<Users>().HasData(new Users()
            {
                RoleId = 2,
                EmailAddress = "pzix886@gmail.com",
                UserId = 1,
                IpAddress = "192.168.1.127",
                Password = PasswordHelper.EncodePasswordMd5("123"),
                PhoneNumber = "09121111111",
                RegisterDate = DateTime.Now,
                Username = "Admin",
                WalletId = 1
            });

            #endregion

            #region Roles

            //modelBuilder.Entity<Roles>().HasData(new Roles()
            //{
            //    RoleId = 1,
            //    RoleName = "User"
            //},
            //    new Roles()
            //    {
            //        RoleId = 2,
            //        RoleName = "Admin"
            //    });


            #endregion

            #region Categories

            modelBuilder.Entity<Categories>().HasData(new Categories()
            {
                CategoryId = 1,
                CategoryName = "Movie"
            },
                new Categories()
                {
                    CategoryId = 2,
                    CategoryName = "TvSeries"
                });

            #endregion

            #region Genres

            modelBuilder.Entity<Genres>().HasData(new Genres()
            {
                GenreId = 1,
                GenreName = "Action"
            },
                new Genres()
                {
                    GenreId = 2,
                    GenreName = "Horror"
                },
                new Genres()
                {
                    GenreId = 3,
                    GenreName = "Exciting"
                },
                new Genres()
                {
                    GenreId = 4,
                    GenreName = "Drama"
                },
                new Genres()
                {
                    GenreId = 5,
                    GenreName = "History"
                },
                new Genres()
                {
                    GenreId = 6,
                    GenreName = "Family"
                },
                new Genres()
                {
                    GenreId = 7,
                    GenreName = "Animation"
                });

            #endregion

            #region Movies

            modelBuilder.Entity<Items>().HasData(new Items()
            {
                Title = "The Batman",
                Actors = "Robert Pattinson , Zoë Kravitz , Jeffrey Wright",
                AgeRating = "PG-13",
                AvailableQualities = "4K,1080p,720p",
                Banner = "1-TheBatman.jpg",
                Description =
                    "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.",
                Director = "Matt Reeves",
                ImdbScore = "8.4",
                ItemId = 1,
                Language = "Eng",
                ManufacturerCountry = "USA",
                MetaCriticScore = "72",
                ReleaseYear = "2022",
                RunningTime = "176'",
                AddedTime = DateTime.Now,
                TrailerLink = "https://www.youtube.com/embed/mqqft2x_Aa4"
            },
                new Items()
                {
                    ItemId = 2,
                    Language = "Eng",
                    MetaCriticScore = "55",
                    ReleaseYear = "2022",
                    RunningTime = "106'",
                    Actors = "Ryan Reynolds , Walker Scobell , Mark Ruffalo",
                    AgeRating = "PG-13",
                    Banner = "2-TheAdamProject.jpg",
                    Description = "After accidentally crash-landing in 2022, time-traveling fighter pilot Adam Reed teams up with his 12-year-old self for a mission to save the future.",
                    AvailableQualities = "4K,1080p,720p",
                    Director = "Shawn Levy",
                    ImdbScore = "6.8",
                    Title = "The Adam Project",
                    AddedTime = DateTime.Now,
                    TrailerLink = "https://www.youtube.com/embed/IE8HIsIrq4o"
                },
                new Items()
                {
                    ItemId = 3,
                    Language = "Eng",
                    MetaCriticScore = "83",
                    ReleaseYear = "2022",
                    RunningTime = "100'",
                    Actors = "Rosalie Chiang , Sandra Oh , Ava Morse",
                    AgeRating = "PG",
                    Banner = "3-TurningRed.jpg",
                    Description = "A 13-year-old girl named Meilin turns into a giant red panda whenever she gets too excited.",
                    AvailableQualities = "4K,1080p,720p",
                    Director = "Domee Shi",
                    ImdbScore = "7.1",
                    Title = "Turning Red",
                    AddedTime = DateTime.Now,
                    TrailerLink = "https://www.youtube.com/embed/XdKzUbAiswE"
                },
                new Items()
                {
                    ItemId = 4,
                    Language = "Eng",
                    MetaCriticScore = "71",
                    ReleaseYear = "2021",
                    RunningTime = "148'",
                    Actors = "Tom Holland , Zendaya , Benedict Cumberbatch",
                    AgeRating = "PG-13",
                    Banner = "4-Spider-Man:NoWayHome.jpg",
                    Description = "With Spider-Man's identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear, forcing Peter to discover what it truly means to be Spider-Man.",
                    AvailableQualities = "4K,1080p,720p",
                    Director = "Jon Watts",
                    ImdbScore = "8.5",
                    Title = "Spider-Man: No Way Home",
                    AddedTime = DateTime.Now,
                    TrailerLink = "https://www.youtube.com/embed/JfVOs4VSpmA"
                },
                new Items()
                {
                    ItemId = 5,
                    Language = "Eng",
                    MetaCriticScore = "52",
                    ReleaseYear = "2022",
                    RunningTime = "115'",
                    Actors = "Ben Affleck , Ana de Armas , Tracy Letts",
                    AgeRating = "R",
                    Banner = "5-DeepWater.jpg",
                    Description = "A well-to-do husband who allows his wife to have affairs in order to avoid a divorce becomes a prime suspect in the disappearance of her lovers.",
                    AvailableQualities = "4K,1080p,720p",
                    Director = "Adrian Lyne",
                    ImdbScore = "5.4",
                    Title = "Deep Water",
                    AddedTime = DateTime.Now,
                    TrailerLink = "https://www.youtube.com/embed/h0zqe_As_qo"
                },
                new Items()
                {
                    ItemId = 6,
                    Language = "Eng",
                    MetaCriticScore = "74",
                    ReleaseYear = "2021",
                    RunningTime = "155'",
                    Actors = "Timothée Chalamet , Rebecca Ferguson , Zendaya",
                    AgeRating = "PG-13",
                    Banner = "6-Dune.jpg",
                    Description = "A noble family becomes embroiled in a war for control over the galaxy's most valuable asset while its scion becomes troubled by visions of a dark future.",
                    AvailableQualities = "4K,1080p,720p",
                    Director = "Denis Villeneuve",
                    ImdbScore = "8.1",
                    Title = "Dune",
                    AddedTime = DateTime.Now,
                    TrailerLink = "https://www.youtube.com/embed/8g18jFHCLXk"
                });

            #endregion

            #region Series

            modelBuilder.Entity<Items>().HasData(new Items()
            {
                AddedTime = DateTime.Now,
                Actors = "Alexander Dreymon , Eliza Butterworth , Arnas Fedaravicius",
                AgeRating = "TV-MA",
                Banner = "12-TheLastKingdom.jpg",
                AvailableQualities = "480p,720p,1080p",
                Description = "As Alfred the Great defends his kingdom from Norse invaders, Uhtred--born a Saxon but raised by Vikings--seeks to claim his ancestral birthright.",
                Director = "Jon East , Edward Bazalgette , Peter Hoar , Alexander Dreymon , Sarah O'Gorman",
                EndRunningYear = "-",
                ImdbScore = "8.5",
                Episodes = 46,
                ItemId = 12,
                Language = "Eng",
                ReleaseYear = "2015",
                RunningTime = "60'",
                Seasons = 5,
                Title = "The Last Kingdom",
                TrailerLink = "https://www.youtube.com/embed/NNBNX34mO34"
            },
                new Items()
                {
                    AddedTime = DateTime.Now,
                    Actors = "Cillian Murphy , Paul Anderson , Sophie Rundle",
                    AgeRating = "TV-MA",
                    Banner = "13-PeakyBlinders.jpg",
                    AvailableQualities = "480p,720p,1080p",
                    Description = "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.",
                    Director = "Steven Knight",
                    EndRunningYear = "-",
                    ImdbScore = "8.8",
                    Episodes = 36,
                    ItemId = 13,
                    Language = "Eng",
                    ReleaseYear = "2013",
                    RunningTime = "60'",
                    Seasons = 6,
                    Title = "Peaky Blinders",
                    TrailerLink = "https://www.youtube.com/embed/2nsT9uQPIrk"
                },
                new Items()
                {
                    AddedTime = DateTime.Now,
                    Actors = "Emilia Clarke , Peter Dinklage , Kit Harington",
                    AgeRating = "TV-MA",
                    Banner = "14-GameofThrones.jpg",
                    AvailableQualities = "480p,720p,1080p",
                    Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                    Director = "David Benioff , D.B.Weiss",
                    EndRunningYear = "2019",
                    ImdbScore = "9.3",
                    Episodes = 73,
                    ItemId = 14,
                    Language = "Eng",
                    ReleaseYear = "2011",
                    RunningTime = "57'",
                    Seasons = 8,
                    Title = "Game of Thrones",
                    TrailerLink = "https://www.youtube.com/embed/KPLWWIOCOOQ"
                },
                new Items()
                {
                    AddedTime = DateTime.Now,
                    Actors = "Bryan Cranston , Aaron Paul , Anna Gunn",
                    AgeRating = "TV-MA",
                    Banner = "15-BreakingBad.jpg",
                    AvailableQualities = "480p,720p,1080p",
                    Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    Director = "Vince Gilligan",
                    EndRunningYear = "2013",
                    ImdbScore = "9.5",
                    Episodes = 62,
                    ItemId = 15,
                    Language = "Eng",
                    ReleaseYear = "2008",
                    RunningTime = "49'",
                    Seasons = 5,
                    Title = "Breaking Bad",
                    TrailerLink = "https://www.youtube.com/embed/HhesaQXLuRY"
                });

            #endregion

            #region SelectedCategories

            modelBuilder.Entity<SelectedCategory>().HasData(new SelectedCategory()
                {
                    SelectedCategoryId = 4,
                    CategoryId = 1,
                    ItemId = 1
                },
                new SelectedCategory()
                {
                    SelectedCategoryId = 5,
                    CategoryId = 1,
                    ItemId = 2
                }, new SelectedCategory()
                {
                    SelectedCategoryId = 6,
                    CategoryId = 1,
                    ItemId = 3
                }, new SelectedCategory()
                {
                    SelectedCategoryId = 7,
                    CategoryId = 1,
                    ItemId = 4
                }, new SelectedCategory()
                {
                    SelectedCategoryId = 8,
                    CategoryId = 1,
                    ItemId = 5
                }, new SelectedCategory()
                {
                    SelectedCategoryId = 9,
                    CategoryId = 1,
                    ItemId = 6
                }, new SelectedCategory()
                {
                    SelectedCategoryId = 10,
                    CategoryId = 2,
                    ItemId = 12
                }, new SelectedCategory()
                {
                    SelectedCategoryId = 11,
                    CategoryId = 2,
                    ItemId = 13
                }, new SelectedCategory()
                {
                    SelectedCategoryId = 12,
                    CategoryId = 2,
                    ItemId = 14
                }, new SelectedCategory()
                {
                    SelectedCategoryId = 13,
                    CategoryId = 2,
                    ItemId = 15
                });

            #endregion

            #region SelectedGenres

            modelBuilder.Entity<SelectedGenres>().HasData(new SelectedGenres()
            {
                ItemId = 1,
                GenreId = 1,
                SelectedGenresId = 6
            }, new SelectedGenres()
            {
                ItemId = 2,
                GenreId = 1,
                SelectedGenresId = 7
            }, new SelectedGenres()
            {
                ItemId = 2,
                GenreId = 3,
                SelectedGenresId = 8
            }, new SelectedGenres()
            {
                ItemId = 3,
                GenreId = 6,
                SelectedGenresId = 9
            }, new SelectedGenres()
            {
                ItemId = 3,
                GenreId = 7,
                SelectedGenresId = 10
            }, new SelectedGenres()
            {
                ItemId = 4,
                GenreId = 1,
                SelectedGenresId = 11
            }, new SelectedGenres()
            {
                ItemId = 4,
                GenreId = 3,
                SelectedGenresId = 12
            }, new SelectedGenres()
            {
                ItemId = 5,
                GenreId = 4,
                SelectedGenresId = 13
            }, new SelectedGenres()
            {
                ItemId = 6,
                GenreId = 1,
                SelectedGenresId = 14
            }, new SelectedGenres()
            {
                ItemId = 12,
                GenreId = 1,
                SelectedGenresId = 15
            }, new SelectedGenres()
            {
                ItemId = 12,
                GenreId = 4,
                SelectedGenresId = 16
            }, new SelectedGenres()
            {
                ItemId = 12,
                GenreId = 5,
                SelectedGenresId = 17
            }, new SelectedGenres()
            {
                ItemId = 13,
                GenreId = 1,
                SelectedGenresId = 18
            }, new SelectedGenres()
            {
                ItemId = 13,
                GenreId = 4,
                SelectedGenresId = 19
            }, new SelectedGenres()
            {
                ItemId = 14,
                GenreId = 1,
                SelectedGenresId = 20
            }, new SelectedGenres()
            {
                ItemId = 14,
                GenreId = 4,
                SelectedGenresId = 21
            }, new SelectedGenres()
            {
                ItemId = 14,
                GenreId = 5,
                SelectedGenresId = 22
            }, new SelectedGenres()
            {
                ItemId = 15,
                GenreId = 1,
                SelectedGenresId = 23
            }, new SelectedGenres()
            {
                ItemId = 15,
                GenreId = 4,
                SelectedGenresId = 24
            });

            #endregion

            #region Actors

            modelBuilder.Entity<Actors>().HasData(new Actors()
            {
                ActorGender = "Male",
                ActorId = 1,
                ActorImage = "Aaron Paul.jpg",
                ActorName = "Aaron Paul"
            }, new Actors()
            {
                ActorGender = "Male",
                ActorId = 2,
                ActorImage = "Benedict Cumberbatch.jpg",
                ActorName = "Benedict Cumberbatch"
            }, new Actors()
            {
                ActorGender = "Male",
                ActorId = 3,
                ActorImage = "Mark Ruffalo.jpg",
                ActorName = "Mark Ruffalo"
            }, new Actors()
            {
                ActorGender = "Male",
                ActorId = 4,
                ActorImage = "Ryan Reynolds.jpg",
                ActorName = "Ryan Reynolds"
            }, new Actors()
            {
                ActorGender = "Female",
                ActorId = 5,
                ActorImage = "Ana De Armas.jpg",
                ActorName = "Ana De Armas"
            }, new Actors()
            {
                ActorGender = "Female",
                ActorId = 6,
                ActorImage = "Zendaya.jpg",
                ActorName = "Zendaya"
            });

            #endregion

            #region SelectedMovies

            modelBuilder.Entity<SelectedMovies>().HasData(new SelectedMovies()
            {
                SelectedMovieId = 1,
                ActorId = 1,
                ItemId = 15
            }, new SelectedMovies()
            {
                SelectedMovieId = 2,
                ActorId = 2,
                ItemId = 4
            }, new SelectedMovies()
            {
                SelectedMovieId = 3,
                ActorId = 3,
                ItemId = 2
            }, new SelectedMovies()
            {
                SelectedMovieId = 4,
                ActorId = 4,
                ItemId = 2
            }, new SelectedMovies()
            {
                SelectedMovieId = 5,
                ActorId = 5,
                ItemId = 5
            }, new SelectedMovies()
            {
                SelectedMovieId = 6,
                ActorId = 6,
                ItemId = 4
            }, new SelectedMovies()
            {
                SelectedMovieId = 7,
                ActorId = 6,
                ItemId = 6
            });

            #endregion

            #endregion

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
