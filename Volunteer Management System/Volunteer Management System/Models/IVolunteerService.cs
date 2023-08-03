using System.Collections.Generic;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Services
{
    public interface IVolunteerService
    {
        // Method to retrieve all volunteers with optional search term
        IEnumerable<Volunteer> GetVolunteers(string searchTerm = null);

        // Method to retrieve a specific volunteer by ID
        Volunteer GetVolunteer(string id);

        // Method to add a new volunteer
        void AddVolunteer(Volunteer newVolunteer);

        // Method to update an existing volunteer
        void UpdateVolunteer(Volunteer updatedVolunteer);

        // Method to delete a volunteer
        void DeleteVolunteer(string id);

        // Method to retrieve opportunities matched with a volunteer
        IEnumerable<Opportunity> GetOpportunityMatches(string volunteerId);
    }
}
