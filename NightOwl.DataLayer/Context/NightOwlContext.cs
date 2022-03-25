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
        public NightOwlContext(DbContextOptions<NightOwlContext> options):base(options)
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
                WalletId =1 
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

            #endregion

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
