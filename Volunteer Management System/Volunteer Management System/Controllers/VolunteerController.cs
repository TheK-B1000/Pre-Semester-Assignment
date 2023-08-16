using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly IDatabaseRepository _databaseRepository;
        private readonly DatabaseRepository _db = new DatabaseRepository();

        public VolunteerController(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        public IActionResult ManageVolunteers(string id)
        {
            List<Volunteer> volunteers = _db.GetVolunteers(id);
            return View(volunteers);
        }

        public IActionResult ChangeVolunteerFilter(string filter)
        {
            return View("ManageVolunteers");
        }

        public IActionResult VolunteerDetails()
        {
            return View();
        }

        public IActionResult VolunteerAdded()
        {
            return View();
        }

        public IActionResult EditVolunteer()
        {
            return View();
        }

        public IActionResult AddVolunteer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VolunteerAdded(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                _databaseRepository.AddVolunteer(volunteer);
                return RedirectToAction("VolunteerAdded");
            }
            return View(volunteer);
        }

        public IActionResult DeleteVolunteer(string id)
        {
            _databaseRepository.DeleteVolunteer(id);
            return RedirectToAction("ManageVolunteers");
        }
        public IActionResult SearchVolunteers(string query)
        {
            return View("ManageVolunteers");
        }
    }
}
