using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;
using Volunteer_Management_System.Services;
using System.Collections.Generic;

namespace Volunteer_Management_System.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly IVolunteerService _volunteerService;

        public VolunteerController(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        public IActionResult Index(string searchTerm)
        {
            var volunteers = _volunteerService.GetVolunteers(searchTerm);
            return View(volunteers);
        }

        public IActionResult ViewMatches(string volunteerId)
        {
            var opportunities = _volunteerService.GetOpportunityMatches(volunteerId);
            return View(opportunities);
        }

        public IActionResult Edit(string volunteerId)
        {
            var volunteer = _volunteerService.GetVolunteer(volunteerId);
            return View(volunteer);
        }

        [HttpPost]
        public IActionResult Edit(Volunteer volunteer)
        {
            try
            {
                _volunteerService.UpdateVolunteer(volunteer);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "An error occurred while trying to update the volunteer. Please try again.";
                return View(volunteer);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Volunteer volunteer)
        {
            try
            {
                _volunteerService.AddVolunteer(volunteer);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "An error occurred while trying to add the volunteer. Please try again.";
                return View(volunteer);
            }
        }

        public IActionResult Delete(string volunteerId)
        {
            _volunteerService.DeleteVolunteer(volunteerId);
            return RedirectToAction("Index");
        }
    }
}
