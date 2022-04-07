using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services
{
    public class CategoryRepository:ICategoryRepository
    {
        private NightOwlContext _context;

        public CategoryRepository(NightOwlContext context)
        {
            _context = context; 
        }

        public List<Categories> GetAllCategories()
        {
           return _context.Categories
               .ToList();
        }
    }
}
