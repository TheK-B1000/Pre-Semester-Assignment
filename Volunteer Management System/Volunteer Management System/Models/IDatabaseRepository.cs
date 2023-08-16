namespace Volunteer_Management_System.Models
{
    public interface IDatabaseRepository
    {
        // Admin methods
        IEnumerable<Admin> GetAllAdmins();
        Admin GetAdmin(string id); 
        void AddAdmin(Admin admin);

        // Volunteer methods
        IEnumerable<Volunteer> GetAllVolunteers();
        List<Volunteer> GetVolunteers(string id); 
        void AddVolunteer(Volunteer volunteer);
        void UpdateVolunteer(Volunteer volunteer);
        void DeleteVolunteer(string id); 

        // Opportunity methods
        IEnumerable<Opportunity> GetAllOpportunities();
        Opportunity GetOpportunity(string id); 
        void AddOpportunity(Opportunity opportunity);
        void UpdateOpportunity(Opportunity opportunity);
        void DeleteOpportunity(string id); 
    }
}
