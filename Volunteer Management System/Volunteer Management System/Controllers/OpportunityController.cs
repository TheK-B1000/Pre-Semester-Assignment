using Microsoft.AspNetCore.Mvc;
using Volunteer_Management_System.Models;

public class OpportunityController : Controller
{
    private readonly IDatabaseRepository _databaseRepository;

    public OpportunityController(IDatabaseRepository databaseRepository)
    {
        _databaseRepository = databaseRepository;
    }

    public IActionResult ViewVolunteerMatches(string opportunityId)
    {
        var matchedVolunteers = _databaseRepository.GetMatchedOpportunitiesForVolunteer(opportunityId);
        return View(matchedVolunteers);
    }

    public IActionResult GetMatchedVolunteers(string opportunityId)
    {
        var matchedVolunteers = _databaseRepository.GetMatchedOpportunitiesForVolunteer(opportunityId);
        return View("OpportunityMatches", matchedVolunteers);
    }

    public IActionResult OpportunityDetails()
    {
        return View();
    }

    public IActionResult Edit()
    {
       
        return View();
    }

    public IActionResult AddOpportunity()
    {
        return View();
    }

    public IActionResult OpportunityAdded()
    {
        return View();
    }


    public IActionResult DeleteOpportunity(string id)
    {
        return View();
    }

    public IActionResult SearchOpportunities(string query)
    {
        return View();
    }

}
