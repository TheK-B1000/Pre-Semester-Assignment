using System.Collections.Generic;
using Volunteer_Management_System.Models;

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
    }

}