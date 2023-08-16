using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Controllers
{
     public class HomeController : Controller
     {
        private DatabaseRepository _db;

        //constructor
        public HomeController()
        {
            _db = new DatabaseRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult ManageVolunteers(string id)
        {
            var volunteers = _db.GetVolunteers(id); 
            return View(volunteers);
        }

        public IActionResult ManageOpportunities()
        {
            return View();
        }

    }
}
