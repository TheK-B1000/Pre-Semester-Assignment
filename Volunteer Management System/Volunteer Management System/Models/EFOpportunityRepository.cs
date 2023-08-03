using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Volunteer_Management_System.Models
{
    public class EFOpportunityRepository : IOpportunityRepository
    {
        private AppDbContext context;

        public EFOpportunityRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Opportunity> Opportunities => context.Opportunities;

        public void AddOpportunity(Opportunity opportunity)
        {
            // Implement the method to add an opportunity
            throw new NotImplementedException();
        }

        public void UpdateOpportunity(Opportunity opportunity)
        {
            // Implement the method to update an opportunity
            throw new NotImplementedException();
        }

        public void DeleteOpportunity(string OpportunityID)
        {
            // Implement the method to delete an opportunity
            throw new NotImplementedException();
        }

        public IEnumerable<Opportunity> FilterOpportunities(string filter)
        {
            // Implement the method to filter opportunities
            throw new NotImplementedException();
        }

        public IEnumerable<Opportunity> SearchOpportunities(string query)
        {
            // Implement the method to search opportunities
            throw new NotImplementedException();
        }
    }
}
