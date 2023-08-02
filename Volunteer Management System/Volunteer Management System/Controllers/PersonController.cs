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

        public ViewResult List(string role, int page = 1)
            => View(new PeopleListViewModel
            {
                 People = repository.People
                    .Where(p => role == null || p.Role == role)
                    .OrderBy(p => p.PersonID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                 PagingInfo = new PagingInfo
                 {
                     CurrentPage = page,
                     ItemsPerPage = PageSize,
                     TotalItems = role == null ?
                        repository.People.Count() :
                        repository.People.Where(e =>
                            e.Role == role).Count()
                 },
                CurrentRole = role
            });
    }
}
