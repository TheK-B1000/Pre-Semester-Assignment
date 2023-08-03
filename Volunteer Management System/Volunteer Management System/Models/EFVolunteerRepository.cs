using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Volunteer_Management_System.Models
{
    public class EFVolunteerRepository : IVolunteerRepository
    {
        private AppDbContext context;
        public EFVolunteerRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Volunteer> Volunteers => context.Volunteers;

        public void AddVolunteer(Volunteer volunteer)
        {
            // Implement the method to add a volunteer
            throw new NotImplementedException();
        }

        public void UpdateVolunteer(Volunteer volunteer)
        {
            // Implement the method to update a volunteer
            throw new NotImplementedException();
        }

        public void DeleteVolunteer(string PersonID)
        {
            // Implement the method to delete a volunteer
            throw new NotImplementedException();
        }

        public IEnumerable<Volunteer> FilterVolunteers(string filter)
        {
            // Implement the method to filter volunteers
            throw new NotImplementedException();
        }

        public IEnumerable<Volunteer> SearchVolunteers(string query)
        {
            // Implement the method to search volunteers
            throw new NotImplementedException();
        }
    }
}
