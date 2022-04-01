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
    public class AccountRepository : IAccountRepository
    {
        private NightOwlContext _context;

        public AccountRepository(NightOwlContext context)
        {
            _context = context;
        }

        public bool AddNewAdmin(Admins newAdmin)
        {
            _context.Admins.Add(newAdmin);
            _context.SaveChanges();
            return true;
        }

        public Admins? GetAdmin(string emailAddress, string password)
        {
            return _context.Admins
                .SingleOrDefault(a =>
                a.AdminEmailAddress == emailAddress && a.Password == password);
        }
    }
}
