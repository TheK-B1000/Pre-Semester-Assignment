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

    public class DBAdmin : Person
    {
        [Required]
        public string Title { get; set; }
    }

    public class DBVolunteer : Person
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
        public string Status { get; set; }
    }
}

