using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Volunteer_Management_System.Models
{
    public class Person
    {
        public string PersonID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumbers { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Role { get; set; } // To indicate whether the person is an 'Admin' or 'Volunteer'
    }

    public class Admin : Person
    {
        [Required]
        public string ApprovalStatus { get; set; }
    }

    public class Volunteer : Person
    {
        public string Centers { get; set; }
        public string SkillsOrInterests { get; set; }
        public string AvailabilityTimes { get; set; }
        public string EducationalBackground { get; set; }
        public string CurrentLicenses { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactEmail { get; set; }
        public bool DriversLicenseOnFile { get; set; }
        public bool SocialSecurityCardOnFile { get; set; }
    }

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
