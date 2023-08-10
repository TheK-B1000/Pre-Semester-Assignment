using Microsoft.AspNetCore.Mvc;

namespace Volunteer_Management_System.Controllers
{
     public class HomeController : Controller
     {
        
         //constructor
         public HomeController()
         {

         }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult ManageVolunteers()
        {
            return View();
        }

        public IActionResult ManageOpportunities()
        {
            return View();
        }

    }
}
