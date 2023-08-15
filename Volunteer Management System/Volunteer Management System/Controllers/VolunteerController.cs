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
            var volunteers = _volunteerRepository.FilterVolunteers(filter);
            return View("ManageVolunteers", volunteers);
        }

        public IActionResult VolunteerDetails()
        {
            return View();
        }

        public IActionResult VolunteerAdded()
        {
            return View();
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
                _volunteerRepository.UpdateVolunteer(volunteer);
            }

            return RedirectToAction("ManageVolunteers");
        }

        public IActionResult AddVolunteer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVolunteer(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                _volunteerRepository.AddVolunteer(volunteer);
                TempData["Message"] = "New volunteer added successfully!";
                return RedirectToAction("ManageVolunteers");
            }

            // If model state is not valid, return to the same view to show validation errors
            return View("AddVolunteers");
        }

        public IActionResult DeleteVolunteer(string id)
        {
            _volunteerRepository.DeleteVolunteer(id);
            return RedirectToAction("ManageVolunteers");
        }

        public IActionResult SearchVolunteers(string query)
        {
            var volunteers = _volunteerRepository.SearchVolunteers(query);
            return View("ManageVolunteers", volunteers);
        }
    }
}
