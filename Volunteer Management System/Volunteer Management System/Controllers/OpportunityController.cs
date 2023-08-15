﻿using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;

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
        var opportunities = _opportunityRepository.FilterOpportunities(filter);
        return View("ManageOpportunities", opportunities);
    }

    public IActionResult OpportunityDetails()
    {
        return View();
    }

    public IActionResult Edit()
    {
       
        return View();
    }

    [HttpPost]
    public IActionResult EditOpportunity(Opportunity opportunity)
    {
        if (ModelState.IsValid)
        {
            _opportunityRepository.UpdateOpportunity(opportunity);
        }

        return RedirectToAction("ManageOpportunities");
    }

    public IActionResult AddOpportunity()
    {
        return View();
    }

    public IActionResult OpportunityAdded()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddOpportunity(Opportunity opportunity)
    {
        if (ModelState.IsValid)
        {
            _opportunityRepository.AddOpportunity(opportunity);
        }

        return RedirectToAction("ManageOpportunities");
    }

    public IActionResult DeleteOpportunity(string id)
    {
        _opportunityRepository.DeleteOpportunity(id);

        return RedirectToAction("ManageOpportunities");
    }

    public IActionResult SearchOpportunities(string query)
    {
        var opportunities = _opportunityRepository.SearchOpportunities(query);
        return View("ManageOpportunities", opportunities);
    }

}
