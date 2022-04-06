using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.DataLayer.Entities;
using NightOwl.Utility.Generators;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IAccountRepository
    {
        Admins GetAdmin(string emailAddress, string password);
        bool AddNewAdmin(Admins newAdmin);
        IEnumerable<Admins> GetAllAdmins();
        Admins GetAdminByAdminId(int adminId);
        void SaveChanges();
        void RemoveAdmin(Admins admin);
        IEnumerable<Admins> GetAdminRequests();
    }
}
