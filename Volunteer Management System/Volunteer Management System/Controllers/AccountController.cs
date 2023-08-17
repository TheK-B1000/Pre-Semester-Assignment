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
        private readonly IDatabaseRepository _databaseRepository;

        public AccountController(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        public IActionResult ManageAdmins()
        {
            var admins = _databaseRepository.GetAllAdmins();
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
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var admins = _databaseRepository.GetAllAdmins();
            return View(admins);
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
