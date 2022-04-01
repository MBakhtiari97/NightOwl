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
        IAccountRepository _accountRepository;
        INotyfService _notyfService;

        public AccountController(IAccountRepository accountRepository, INotyfService notyfService)
        {
            _accountRepository = accountRepository;
            _notyfService = notyfService;
        }

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
                    new Claim(ClaimTypes.Email, admin.AdminEmailAddress)
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
            return View();
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

    }
}
