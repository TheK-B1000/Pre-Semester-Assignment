using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Volunteer_Management_System.Models;
using Volunteer_Management_System.Services;

namespace Volunteer_Management_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
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
                var isValidUser = _accountService.ValidateCredentials(admin.Username, admin.Password);

                if (isValidUser)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, admin.Username),
                        new Claim(ClaimTypes.Role, "Administrator")
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");
            }

            return View(admin);
        }

        public IActionResult ManageVolunteers()
        {
            return RedirectToAction("Index", "Volunteer");
        }

        public IActionResult ManageOpportunities()
        {
            return RedirectToAction("Index", "Opportunity");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
