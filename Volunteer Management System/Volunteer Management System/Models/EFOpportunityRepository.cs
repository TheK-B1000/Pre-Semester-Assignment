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
            context.Opportunities.Add(opportunity);
            context.SaveChanges();
        }

        public void UpdateOpportunity(Opportunity opportunity)
        {
            var opportunityToUpdate = context.Opportunities.FirstOrDefault(o => o.OpportunityID == opportunity.OpportunityID);
            if (opportunityToUpdate != null)
            {
                opportunityToUpdate.Name = opportunity.Name;
                opportunityToUpdate.Description = opportunity.Description;
                opportunityToUpdate.Center = opportunity.Center;
                opportunityToUpdate.Date = opportunity.Date;
                opportunityToUpdate.Duration = opportunity.Duration;
                opportunityToUpdate.MaximumVolunteers = opportunity.MaximumVolunteers;
                opportunityToUpdate.CurrentVolunteers = opportunity.CurrentVolunteers;

                context.SaveChanges();
            }
        }

        public void DeleteOpportunity(string OpportunityID)
        {
            var opportunityToDelete = context.Opportunities.FirstOrDefault(o => o.OpportunityID == OpportunityID);
            if (opportunityToDelete != null)
            {
                context.Opportunities.Remove(opportunityToDelete);
                context.SaveChanges();
            }
        }

        public IEnumerable<Opportunity> FilterOpportunities(string filter)
        {
            return context.Opportunities.Where(o => o.Name.Contains(filter)).ToList();
        }

        public IEnumerable<Opportunity> SearchOpportunities(string query)
        {
            return context.Opportunities.Where(o => o.Name.Contains(query) || o.Description.Contains(query)).ToList();
        }
    }
}
