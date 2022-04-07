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
            _context.Admins
                .Add(newAdmin);

            _context.SaveChanges();
            return true;
        }

        public Admins GetAdmin(string emailAddress, string password)
        {
            return _context.Admins
                .SingleOrDefault(a =>
                a.AdminEmailAddress == emailAddress && a.Password == password);
        }

        public Admins GetAdminByAdminId(int adminId)
        {
            return _context.Admins
                .Find(adminId);
        }

        public Admins GetAdminForRecovery(string emailAddress)
        {
            return _context.Admins
                .SingleOrDefault(a => a.AdminEmailAddress == emailAddress);
        }

        public IEnumerable<Admins> GetAdminRequests()
        {
            return _context.Admins
                .Where(a => a.IsActive == false)
                .ToList();
        }

        public IEnumerable<Admins> GetAllAdmins()
        {
           return _context.Admins
               .ToList();
        }

        public IEnumerable<Admins> GetRecoverPasswordRequests()
        {
            return _context.Admins
                .Where(a => a.ForgotPassword == true)
                .ToList();
        }

        public void RemoveAdmin(Admins admin)
        {
            _context.Admins
                .Remove(admin);

            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
