namespace Volunteer_Management_System.Models
{
    public interface IDatabaseRepository
    {
        IEnumerable<Volunteer> GetAllVolunteers();
        IEnumerable<Opportunity> GetAllOpportunities();
        IEnumerable<Opportunity> GetMatchedOpportunitiesForVolunteer(string volunteerId);
    }
}
