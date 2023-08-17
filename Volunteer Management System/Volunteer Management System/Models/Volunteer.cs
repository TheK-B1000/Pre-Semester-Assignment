using System.ComponentModel.DataAnnotations;

namespace Volunteer_Management_System.Models
{
    public class Volunteer
    {
        public string VolunteerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumbers { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Centers { get; set; }
        public string SkillsOrInterests { get; set; }
        public string AvailabilityTimes { get; set; }
        public string EducationalBackground { get; set; }
        public string CurrentLicenses { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactEmail { get; set; }
        public string EmergencyContactAddress { get; set; }
        public bool DriversLicenseOnFile { get; set; }
        public bool SocialSecurityCardOnFile { get; set; }
        public string Status { get; set; }
    }
}
