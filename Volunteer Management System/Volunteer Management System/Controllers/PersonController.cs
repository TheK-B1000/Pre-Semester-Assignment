using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;
using Volunteer_Management_System.Models.ViewModels;

namespace Volunteer_Management_System.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private IPersonRepository repository;
        public int PageSize = 4;
        public PersonController(IPersonRepository repo)
        {
            repository = repo;
        }

       
    }
}
