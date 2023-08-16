namespace Volunteer_Management_System.Models
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private List<Admin> admins = new List<Admin>();
        private List<Volunteer> volunteers = new List<Volunteer>();
        private List<Opportunity> opportunities = new List<Opportunity>();

        public DatabaseRepository()
        {
            // Initialize lists in the constructor to ensure they are not null.
            volunteers = new List<Volunteer>();
            opportunities = new List<Opportunity>();
        }

        // Admin operations
        public IEnumerable<Admin> GetAllAdmins()
        {
            return admins;
        }

        public Admin GetAdmin(string id)
        {
            return admins.FirstOrDefault(a => a.AdminID == id);
        }

        public void AddAdmin(Admin admin)
        {
            if (admin != null)
            {
                admins.Add(admin);
            }
        }

        // Volunteer operations
        public IEnumerable<Volunteer> GetAllVolunteers()
        {
            return volunteers;
        }

        public void AddVolunteer(Volunteer volunteer)
        {
            volunteers.Add(volunteer);
        }

        public List<Volunteer> GetVolunteers(string id)
        {
            return volunteers.Where(v => v.VolunteerID == id).ToList();
        }


        public void UpdateVolunteer(Volunteer volunteer)
        {
            var existingVolunteer = volunteers.FirstOrDefault(v => v.VolunteerID == volunteer.VolunteerID);
            if (existingVolunteer != null)
            {
                volunteers.Remove(existingVolunteer);
                volunteers.Add(volunteer);
            }
        }

        public void DeleteVolunteer(string id)
        {
            var volunteerToRemove = volunteers.FirstOrDefault(v => v.VolunteerID == id);
            if (volunteerToRemove != null)
            {
                volunteers.Remove(volunteerToRemove);
            }
        }

        // Opportunity operations
        public IEnumerable<Opportunity> GetAllOpportunities()
        {
            return opportunities;
        }

        public Opportunity GetOpportunity(string id)
        {
            return opportunities.FirstOrDefault(o => o.OpportunityID == id);
        }

        public void AddOpportunity(Opportunity opportunity)
        {
            if (opportunity != null)
            {
                opportunities.Add(opportunity);
            }
        }

        public void UpdateOpportunity(Opportunity opportunity)
        {
            var existingOpportunity = opportunities.FirstOrDefault(o => o.OpportunityID == opportunity.OpportunityID);
            if (existingOpportunity != null)
            {
                opportunities.Remove(existingOpportunity);
                opportunities.Add(opportunity);
            }
        }

        public void DeleteOpportunity(string id)
        {
            var opportunityToRemove = opportunities.FirstOrDefault(o => o.OpportunityID == id);
            if (opportunityToRemove != null)
            {
                opportunities.Remove(opportunityToRemove);
            }
        }
    }
}
