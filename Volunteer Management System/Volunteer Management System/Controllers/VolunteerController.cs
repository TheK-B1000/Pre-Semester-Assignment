using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly IVolunteerRepository _volunteerRepository;

        public VolunteerController(IVolunteerRepository volunteerRepository)
        {
            _volunteerRepository = volunteerRepository;
        }

        public IActionResult ManageVolunteers()
        {
            var volunteers = _volunteerRepository.Volunteers;
            return View(volunteers);
        }

        public IActionResult ChangeVolunteerFilter(string filter)
        {
            var volunteers = _volunteerRepository.Volunteers; 
            return View("ManageVolunteers", volunteers);
        }

        public IActionResult EditVolunteer(string id)
        {
            var volunteer = _volunteerRepository.Volunteers.FirstOrDefault(v => v.PersonID == id);
            if (volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);
        }

        [HttpPost]
        public IActionResult EditVolunteer(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                // Save the edited volunteer data
            }

            return RedirectToAction("ManageVolunteers");
        }

        public IActionResult AddVolunteer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddVolunteer(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                // Add the new volunteer data
            }

            return RedirectToAction("ManageVolunteers");
        }

        public IActionResult SearchVolunteers(string query)
        {
            var volunteers = _volunteerRepository.Volunteers; 
            return View("ManageVolunteers", volunteers);
        }

    }
}

