using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private IPersonRepository repository;
        public PersonController(IPersonRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.People);
    }
}
