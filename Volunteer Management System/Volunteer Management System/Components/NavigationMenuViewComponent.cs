using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IPersonRepository repository;
        public NavigationMenuViewComponent(IPersonRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["approval"];
            return View(repository.People
            .Select(x => x.Approval)
            .Distinct()
            .OrderBy(x => x));
        }

    }
}
