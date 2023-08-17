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


        public VolunteerController()
        {
 
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
