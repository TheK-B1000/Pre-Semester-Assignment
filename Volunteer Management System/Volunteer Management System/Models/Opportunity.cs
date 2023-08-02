using System.ComponentModel.DataAnnotations;

namespace Volunteer_Management_System.Models
{
    public class Opportunity
    {
        public string OpportunityID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Center { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        public int MaximumVolunteers { get; set; }
        public int CurrentVolunteers { get; set; }
    }
}
