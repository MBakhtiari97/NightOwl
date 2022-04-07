using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.DTOs;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Entities;
using NightOwl.Utility.Security;
using Microsoft.AspNetCore.HttpOverrides;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        #region Injection

        IAccountRepository _accountRepository;
        INotyfService _notyfService;

        public AccountController(IAccountRepository accountRepository, INotyfService notyfService)
        {
            _accountRepository = accountRepository;
            _notyfService = notyfService;
        }

        #endregion

        #region Login

        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("/Login")]
        public IActionResult Login(AdminLoginViewModel loginInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(loginInfo);

                var admin = _accountRepository.GetAdmin(loginInfo.EmailAddress.ToLower().Trim(),
                    PasswordHelper.EncodePasswordMd5(loginInfo.Password));


                if (!admin.IsActive)
                {
                    _notyfService.Error("Your account is not active or suspended !");
                    return View(loginInfo);
                }

                //Logging user codes
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, admin.AdminId.ToString()),
                    new Claim(ClaimTypes.Name, admin.AdminName),
                    new Claim(ClaimTypes.Email, admin.AdminEmailAddress),
                    new Claim("IsModerator", admin.IsModerator.ToString())
                };

                var identifier = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identifier);
                var properties = new AuthenticationProperties()
                {
                    IsPersistent = loginInfo.RememberMe
                };

                HttpContext.SignInAsync(principal, properties);

            }
            catch
            {
                _notyfService.Error("Couldn't Find Any User With These Credential's ! Please Check Your Information's");
                return View();
            }

            _notyfService.Success("You Successfully Logged On As Admin !");
            return Redirect("/Admin");
        }

        #endregion

        #region Logout

        [Route("/Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }

        #endregion
        
        #region Register

        [Route("/Register")]
        public IActionResult RegisterAdmin()
        {
            return View();
        }
        [HttpPost]
        [Route("/Register")]
        public IActionResult RegisterAdmin(RegisterAdminViewModel registerInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(registerInfo);
            }

            //Creating a new admin and filling it with proper values !
            Admins newAdmin = new Admins()
            {
                AdminEmailAddress = registerInfo.EmailAddress,
                IsActive = false,
                Password = PasswordHelper.EncodePasswordMd5(registerInfo.Password),
                AdminName = registerInfo.UserName,
                AdminPhoneNumber = registerInfo.PhoneNumber,
                AdminIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
            };

            if (_accountRepository.AddNewAdmin(newAdmin))
            {
                _notyfService.Success("Your Admin Subscription Request Has Been Sent Successfully !" +
                                      " You Can Access Admin Panel As Soon As Confirming Your Details !");
            }
            else
            {
                _notyfService.Error("Sorry something wrong happened during registration ! Try again later !");
            }

            return Redirect("/");
        }

        #endregion

        #region ForgotPassword
        [Route("/Forgot")]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Forgot")]
        public IActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
                return View(forgot);

            var admin = _accountRepository.GetAdminForRecovery(forgot.EmailAddress);
            if (admin == null)
            {
                _notyfService.Error("Cannot find any admin with this email address !");
                return View(forgot);
            }

            admin.ForgotPassword = true;
            _accountRepository.SaveChanges();

            _notyfService.Success("Account recovery request has been sent" +
                                  " to moderator successfully ! moderator will" +
                                  " contact you as soon as possible for verification!");

            return Redirect("/Login");
        }

        #endregion

        #region RecoverAccount

        [Route("/Admin/Recover/Confirm/{adminId}")]
        public IActionResult ConfirmRecover(int adminId)
        {
            //Getting admin
            var admin = _accountRepository
                .GetAdminByAdminId(adminId);

            //Generating new password
            var newPassword = adminId + admin.AdminPhoneNumber;
            admin.Password = PasswordHelper.EncodePasswordMd5(newPassword);
            admin.ForgotPassword = false;

            //Saving changes
            _accountRepository.SaveChanges();
            _notyfService.Success("Request Confirmed !");
            return Redirect("/Admin");
        }

        [Route("/Admin/Recover/Decline/{adminId}")]
        public IActionResult DeclineRecover(int adminId)
        {
            //Getting admin
            var admin = _accountRepository
                .GetAdminByAdminId(adminId);

            //Declining request
            admin.ForgotPassword = false;

            //Changing password
            _accountRepository.SaveChanges();
            _notyfService.Success("Request Declined !");
            return Redirect("/Admin");
        }
        #endregion
    }
}
