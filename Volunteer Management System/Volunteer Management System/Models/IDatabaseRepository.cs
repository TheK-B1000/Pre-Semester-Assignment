namespace Volunteer_Management_System.Models
{
    public interface IDatabaseRepository
    {
        IEnumerable<Volunteer> GetAllVolunteers();
        void AddVolunteer(Volunteer volunteer);
        IEnumerable<Opportunity> GetAllOpportunities();
        IEnumerable<Admin> GetAllAdmins();
        Admin GetLoggedInAdmin();
        IEnumerable<Opportunity> GetMatchedOpportunitiesForVolunteer(string volunteerId);
        IEnumerable<Volunteer> GetMatchedVolunteersForOpportunity(string opportunityId);
        
    }
}
