using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class AdminsController : Microsoft.AspNetCore.Mvc.Controller
    {
        #region Injection

        private INotyfService _notyfService;
        private IAccountRepository _accountRepository;

        public AdminsController(INotyfService notyfService, IAccountRepository accountRepository)
        {
            _notyfService = notyfService;
            _accountRepository = accountRepository;
        }


        #endregion

        #region Index

        [Route("/Admin/AdminIndex")]
        public IActionResult GetAllAdmins()
        {
            return View(_accountRepository.GetAllAdmins());
        }


        #endregion

        #region Details

        [Route("/Admin/ManageRequest/Details/{adminId}")]
        public IActionResult AdminDetails(int adminId)
        {
            return View(_accountRepository.GetAdminByAdminId(adminId));
        }


        #endregion

        #region ConfirmRequest

        [Route("/Admin/ManageRequest/Confirm/{adminId}")]
        public IActionResult ConfirmAdminRequest(int adminId)
        {
            try
            {
                var adminRequestDetails = _accountRepository.GetAdminByAdminId(adminId);
                //Changing Active Status
                adminRequestDetails.IsActive = true;
                _accountRepository.SaveChanges();

                _notyfService.Success("Request Confirmed !");

                return Redirect("/Admin/AdminIndex");

            }
            catch
            {
                _notyfService.Error("Failed To Accept Request !");
                return Redirect("/Admin/AdminIndex");
            }

        }

        #endregion

        #region DeclineRequest

        [Route("/Admin/ManageRequest/Decline/{adminId}")]
        public IActionResult DeclineAdminRequest(int adminId)
        {
            try
            {
                var adminRequestDetails = _accountRepository.GetAdminByAdminId(adminId);
                //Removing Admin
                _accountRepository.RemoveAdmin(adminRequestDetails);
                _notyfService.Success("Request Removed Successfully !");

                return Redirect("/Admin/AdminIndex");

            }
            catch
            {
                _notyfService.Error("Failed To Remove Request !");
                return Redirect("/Admin/AdminIndex");
            }

        }

        #endregion
    }
}
