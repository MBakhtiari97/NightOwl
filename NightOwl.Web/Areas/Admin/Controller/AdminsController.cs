using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using NightOwl.DataLayer.Context;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class AdminsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private NightOwlContext _context;
        private INotyfService _notyfService;

        public AdminsController(NightOwlContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [Route("/Admin/ManageRequest/Details/{adminId}")]
        public IActionResult AdminDetails(int adminId)
        {
            var adminRequestDetails = _context.Admins.Find(adminId);

            if(adminRequestDetails==null)
                return NotFound();

            return View(adminRequestDetails);
        }

        [Route("/Admin/ManageRequest/Confirm/{adminId}")]
        public IActionResult ConfirmAdminRequest(int adminId)
        {
            try
            {
                var adminRequestDetails = _context.Admins.Find(adminId);

                if (adminRequestDetails == null)
                    return NotFound();

                adminRequestDetails.IsActive = true;
                _context.SaveChanges();

                _notyfService.Success("Request Confirmed !");

                return Redirect("/Admin");

            }
            catch
            {
                _notyfService.Error("Failed To Accept Request !");
                return Redirect("/Admin");
            }
            
        }

        [Route("/Admin/ManageRequest/Decline/{adminId}")]
        public IActionResult DeclineAdminRequest(int adminId)
        {
            try
            {
                var adminRequestDetails = _context.Admins.Find(adminId);

                if (adminRequestDetails == null)
                    return NotFound();

                _context.Admins.Remove(adminRequestDetails);
                _context.SaveChanges();

                _notyfService.Success("Request Removed Successfully !");

                return Redirect("/Admin");

            }
            catch
            {
                _notyfService.Error("Failed To Remove Request !");
                return Redirect("/Admin");
            }

        }
    }
}
