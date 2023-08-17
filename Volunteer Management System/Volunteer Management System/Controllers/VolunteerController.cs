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

        public VolunteerController(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        public IActionResult ChangeVolunteerFilter(string filter)
        {
            return View("ManageVolunteers");
        }

        public IActionResult VolunteerDetails()
        {
            return View();
        }

        public IActionResult VolunteerAdded(Volunteer volunteer)
        {
            _databaseRepository.AddVolunteer(volunteer);
            return RedirectToAction("ManageVolunteers", "Home");
        }


        public IActionResult EditVolunteer()
        {
            var volunteers = _databaseRepository.GetAllVolunteers();
            return View(volunteers);
        }

        public IActionResult ViewOpportunityMatches(string volunteerId)
        {
            var matchedOpportunities = _databaseRepository.GetMatchedOpportunitiesForVolunteer(volunteerId);
            return View(matchedOpportunities); 
        }

        public IActionResult GetMatchedOpportunities(string volunteerId)
        {
            var matchedOpportunities = _databaseRepository.GetMatchedOpportunitiesForVolunteer(volunteerId);
            return View("VolunteerMatches", matchedOpportunities);
        }


        public IActionResult AddVolunteer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddVolunteer(Volunteer volunteer)
        {
                _databaseRepository.AddVolunteer(volunteer); 
                return RedirectToAction("ManageVolunteers", "Home");
        }

        public IActionResult DeleteVolunteer()
        {
            return View();
        }
        public IActionResult SearchVolunteers()
        {
            return View();
        }
    }
}
