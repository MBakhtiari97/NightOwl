using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NightOwl.DataLayer.Entities;

namespace NightOwl.DataLayer.Context
{
    public class NightOwlContext : DbContext
    {
        public NightOwlContext(DbContextOptions<NightOwlContext> options):base(options)
        {
            
        }

        #region Users
        public DbSet<Users> Users { get; set; }

        #endregion
    }
}
