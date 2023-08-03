using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volunteer_Management_System.Models
{
    public interface IOpportunityRepository
    {
        IEnumerable<Opportunity> Opportunities { get; }
        void AddOpportunity(Opportunity opportunity);
        void UpdateOpportunity(Opportunity opportunity);
        void DeleteOpportunity(string OpportunityID);
        IEnumerable<Opportunity> FilterOpportunities(string filter);
        IEnumerable<Opportunity> SearchOpportunities(string query);
    }
}

