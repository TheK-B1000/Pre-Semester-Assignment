using Microsoft.AspNetCore.Mvc;

namespace Volunteer_Management_System.Controllers
{
    public class VolunteerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
