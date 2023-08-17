using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDatabaseRepository _databaseRepository;

        public HomeController(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
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
            var volunteers = _databaseRepository.GetAllVolunteers();
            return View(volunteers);
        }

        public IActionResult ManageOpportunities()
        {
            var opportunities = _databaseRepository.GetAllOpportunities();
            return View(opportunities);
        }
    } 
}
