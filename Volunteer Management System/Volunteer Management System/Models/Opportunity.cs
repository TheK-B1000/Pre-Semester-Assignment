using System.ComponentModel.DataAnnotations;

namespace Volunteer_Management_System.Models
{
    public class Opportunity
    {
        public string OpportunityID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Center { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public int MaximumVolunteers { get; set; }
        public int CurrentVolunteers { get; set; }
    }
}
