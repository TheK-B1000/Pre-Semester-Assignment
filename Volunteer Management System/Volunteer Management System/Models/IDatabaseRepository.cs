namespace Volunteer_Management_System.Models
{
    public interface IDatabaseRepository
    {
        IEnumerable<Admin> GetAllAdmins();
        IEnumerable<Volunteer> GetAllVolunteers();
        IEnumerable<Opportunity> GetAllOpportunities();
        IEnumerable<Opportunity> GetMatchedOpportunitiesForVolunteer(string volunteerId);
        IEnumerable<Volunteer> GetMatchedVolunteersForOpportunity(string opportunityId);
    }
}
