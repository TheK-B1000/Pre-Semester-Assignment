using System.Collections.Generic;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Services
{
    public interface IOpportunityService
    {
        // Method to retrieve all opportunities with optional filtering
        IEnumerable<Opportunity> GetOpportunities(FilterOptions filterOptions = null);

        // Method to retrieve a specific opportunity by ID
        Opportunity GetOpportunity(string id);

        // Method to add a new opportunity
        void AddOpportunity(Opportunity newOpportunity);

        // Method to update an existing opportunity
        void UpdateOpportunity(Opportunity updatedOpportunity);

        // Method to delete an opportunity
        void DeleteOpportunity(string id);

        // Method to search for opportunities by name or keyword
        IEnumerable<Opportunity> Search(string searchTerm);

        // Method to retrieve volunteers matched with an opportunity
        IEnumerable<Volunteer> GetMatches(string opportunityId);
    }
}
