using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Controllers
{
    public class OpportunityController : Controller
    {
        private readonly IOpportunityRepository _opportunityRepository;

        public OpportunityController(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }

        public IActionResult ManageOpportunities()
        {
            var opportunities = _opportunityRepository.Opportunities;
            return View(opportunities);
        }

        public IActionResult ChangeOpportunityFilter(string filter)
        {
            var opportunities = _opportunityRepository.Opportunities; 
            return View("ManageOpportunities", opportunities);
        }

        public IActionResult EditOpportunity(string id)
        {
            var opportunity = _opportunityRepository.Opportunities.FirstOrDefault(o => o.OpportunityID == id);
            if (opportunity == null)
            {
                return NotFound();
            }

            return View(opportunity);
        }

        [HttpPost]
        public IActionResult EditOpportunity(Opportunity opportunity)
        {
            if (ModelState.IsValid)
            {
                // Save the edited opportunity data
            }

            return RedirectToAction("ManageOpportunities");
        }

        public IActionResult AddOpportunity()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOpportunity(Opportunity opportunity)
        {
            if (ModelState.IsValid)
            {
                // Add the new opportunity data
            }

            return RedirectToAction("ManageOpportunities");
        }

        public IActionResult DeleteOpportunity(int id)
        {
            // Delete the opportunity data

            return RedirectToAction("ManageOpportunities");
        }

        public IActionResult SearchOpportunities(string query)
        {
            var opportunities = _opportunityRepository.Opportunities; 
            return View("ManageOpportunities", opportunities);
        }

    }
}

