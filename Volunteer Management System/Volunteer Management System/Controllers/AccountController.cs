using Microsoft.AspNetCore.Mvc;

namespace Volunteer_Management_System.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
