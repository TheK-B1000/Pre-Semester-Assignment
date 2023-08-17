using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Models
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private List<Volunteer> volunteers = new List<Volunteer>
        {
            new Volunteer
            {
                VolunteerID = "V001",
                FirstName = "John",
                LastName = "Doe",
                Username = "jdoe",
                Password = "password123",
                Address = "123 Elm Street, Springfield",
                PhoneNumbers = "555-1234",
                Email = "jdoe@gmail.com",
                Role = "Cleanup",
                Centers = "Beach Center",
                SkillsOrInterests = "Cleaning, Teaching",
                AvailabilityTimes = "Weekdays 9AM-5PM",
                EducationalBackground = "Bachelor's in Environmental Science",
                CurrentLicenses = "Diving, Driving",
                EmergencyContactName = "Jane Doe",
                EmergencyContactPhone = "555-5678",
                EmergencyContactEmail = "jane@gmail.com",
                DriversLicenseOnFile = true,
                SocialSecurityCardOnFile = true,
                Status = "Active"
            },
            new Volunteer
            {
                VolunteerID = "V002",
                FirstName = "Alice",
                LastName = "Brown",
                Username = "abrown",
                Password = "securepass",
                Address = "456 Oak Street, Rivertown",
                PhoneNumbers = "555-2345",
                Email = "abrown@gmail.com",
                Role = "Teaching",
                Centers = "Downtown Center",
                SkillsOrInterests = "Teaching, Gardening",
                AvailabilityTimes = "Weekends 10AM-2PM",
                EducationalBackground = "Master's in Education",
                CurrentLicenses = "Teaching",
                EmergencyContactName = "Bob Brown",
                EmergencyContactPhone = "555-7890",
                EmergencyContactEmail = "bob@gmail.com",
                DriversLicenseOnFile = false,
                SocialSecurityCardOnFile = true,
                Status = "Inactive"
            },

            new Volunteer
            {
                VolunteerID = "V003",
                FirstName = "Charlie",
                LastName = "Green",
                Username = "cgreen",
                Password = "greenpass",
                Address = "789 Pine Street, Hilltown",
                PhoneNumbers = "555-3456",
                Email = "cgreen@gmail.com",
                Role = "Organizing",
                Centers = "Uptown Center",
                SkillsOrInterests = "Organizing, Planning",
                AvailabilityTimes = "Weekdays 1PM-9PM",
                EducationalBackground = "Bachelor's in Business Management",
                CurrentLicenses = "None",
                EmergencyContactName = "Daisy Green",
                EmergencyContactPhone = "555-0123",
                EmergencyContactEmail = "daisy@gmail.com",
                DriversLicenseOnFile = true,
                SocialSecurityCardOnFile = false,
                Status = "Pending"
            }
        };

        private List<Opportunity> opportunities = new List<Opportunity>
        {
            new Opportunity
            {
                OpportunityID = "O001",
                Name = "Beach Cleanup",
                Description = "Help clean up the beach.",
                Center = "Beach Center",
                Date = DateTime.Now.AddMonths(1),
                Duration = TimeSpan.FromHours(3),
                MaximumVolunteers = 20,
                CurrentVolunteers = 5
            },

            new Opportunity
            {
                OpportunityID = "O002",
                Name = "Park Restoration",
                Description = "Help restore the local park.",
                Center = "Park Center",
                Date = DateTime.Now.AddMonths(2),
                Duration = TimeSpan.FromHours(4),
                MaximumVolunteers = 30,
                CurrentVolunteers = 10
            },
            new Opportunity
            {
                OpportunityID = "O003",
                Name = "Food Bank",
                Description = "Help give food to those in need.",
                Center = "UNF Food Center",
                Date = DateTime.Now.AddMonths(1),
                Duration = TimeSpan.FromHours(3),
                MaximumVolunteers = 40,
                CurrentVolunteers = 10
            }
        };

        public IEnumerable<Volunteer> GetAllVolunteers()
        {
            return volunteers;
        }

        public IEnumerable<Opportunity> GetAllOpportunities()
        {
            return opportunities;
        }

        public IEnumerable<Opportunity> GetMatchedOpportunitiesForVolunteer(string volunteerId)
        {
            var volunteer = volunteers.FirstOrDefault(v => v.VolunteerID == volunteerId);
            if (volunteer == null)
            {
                return new List<Opportunity>();
            }

            var preferredCenter = volunteer.Centers;
            return opportunities.Where(o => o.Center == preferredCenter);
        }

    }
}
