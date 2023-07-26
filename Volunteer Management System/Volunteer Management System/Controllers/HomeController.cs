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
     }
}
