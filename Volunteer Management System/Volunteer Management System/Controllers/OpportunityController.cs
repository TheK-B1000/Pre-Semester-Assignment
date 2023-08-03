using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;
using Volunteer_Management_System.Services;
using System.Collections.Generic;

namespace Volunteer_Management_System.Controllers
{
    public class OpportunityController : Controller
    {
        private readonly IOpportunityService _opportunityService;

        public OpportunityController(IOpportunityService opportunityService)
        {
            _opportunityService = opportunityService;
        }

        public IActionResult Index(FilterOptions filterOptions)
        {
            var opportunities = _opportunityService.GetOpportunities(filterOptions);
            return View(opportunities);
        }

        public IActionResult Search(string keyword)
        {
            var opportunities = _opportunityService.Search(keyword);
            if (opportunities == null)
            {
                ViewBag.Message = "No opportunities matched your search criteria.";
            }
            return View(opportunities);
        }

        public IActionResult ViewMatches(string opportunityId)
        {
            var volunteers = _opportunityService.GetMatches(opportunityId);
            return View(volunteers);
        }

        public IActionResult Edit(string opportunityId)
        {
            var opportunity = _opportunityService.GetOpportunity(opportunityId);
            return View(opportunity);
        }

        [HttpPost]
        public IActionResult Edit(Opportunity opportunity)
        {
            try
            {
                _opportunityService.UpdateOpportunity(opportunity);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "An error occurred while trying to update the opportunity. Please try again.";
                return View(opportunity);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Opportunity opportunity)
        {
            _opportunityService.AddOpportunity(opportunity);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string opportunityId)
        {
            _opportunityService.DeleteOpportunity(opportunityId);
            return RedirectToAction("Index");
        }
    }
}
