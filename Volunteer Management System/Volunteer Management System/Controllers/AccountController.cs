using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAdminRepository _adminRepository;

        public AccountController(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public IActionResult ManageAdmins()
        {
            var admins = _adminRepository.Admins;
            return View(admins);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var isValidUser = _adminRepository.Admins.Any(a => a.Username == admin.Username && a.Password == admin.Password);

                if (isValidUser)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, admin.Username),
                        new Claim(ClaimTypes.Role, "Administrator")
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction("ManageAdmins");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");
            }

            return View(admin);
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult ManageVolunteers()
        {
            return RedirectToAction("ManageVolunteers", "Volunteer");
        }

        public IActionResult ManageOpportunities()
        {
            return RedirectToAction("ManageOpportunities", "Opportunity");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult EmailSent()
        {
            return View();
        }

    }
}
