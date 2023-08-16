﻿using System;
using Volunteer_Management_System.Models;

class Data
{
    static void Main(string[] args)
    {
        DatabaseRepository db = new DatabaseRepository();

        db.AddVolunteer(new Volunteer
        {
            VolunteerID = "V001",
            FirstName = "John",
            LastName = "Doe",
            Username = "jdoe",
            Password = "password123",
            Address = "123 Elm Street, Springfield",
            PhoneNumbers = "555-1234",
            Email = "jdoe@example.com",
            Role = "Cleanup",
            Centers = "Beach Center",
            SkillsOrInterests = "Cleaning, Teaching",
            AvailabilityTimes = "Weekdays 9AM-5PM",
            EducationalBackground = "Bachelor's in Environmental Science",
            CurrentLicenses = "Diving, Driving",
            EmergencyContactName = "Jane Doe",
            EmergencyContactPhone = "555-5678",
            EmergencyContactEmail = "jane@example.com",
            DriversLicenseOnFile = true,
            SocialSecurityCardOnFile = true,
            Status = "Active"
        });

        // Adding Volunteer 2
        db.AddVolunteer(new Volunteer
        {
            VolunteerID = "V002",
            FirstName = "Alice",
            LastName = "Brown",
            Username = "abrown",
            Password = "securepass",
            Address = "456 Oak Street, Rivertown",
            PhoneNumbers = "555-2345",
            Email = "abrown@example.com",
            Role = "Teaching",
            Centers = "Downtown Center",
            SkillsOrInterests = "Teaching, Gardening",
            AvailabilityTimes = "Weekends 10AM-2PM",
            EducationalBackground = "Master's in Education",
            CurrentLicenses = "Teaching",
            EmergencyContactName = "Bob Brown",
            EmergencyContactPhone = "555-7890",
            EmergencyContactEmail = "bob@example.com",
            DriversLicenseOnFile = false,
            SocialSecurityCardOnFile = true,
            Status = "Inactive"
        });

        // Adding Volunteer 3
        db.AddVolunteer(new Volunteer
        {
            VolunteerID = "V003",
            FirstName = "Charlie",
            LastName = "Green",
            Username = "cgreen",
            Password = "greenpass",
            Address = "789 Pine Street, Hilltown",
            PhoneNumbers = "555-3456",
            Email = "cgreen@example.com",
            Role = "Organizing",
            Centers = "Uptown Center",
            SkillsOrInterests = "Organizing, Planning",
            AvailabilityTimes = "Weekdays 1PM-9PM",
            EducationalBackground = "Bachelor's in Business Management",
            CurrentLicenses = "None",
            EmergencyContactName = "Daisy Green",
            EmergencyContactPhone = "555-0123",
            EmergencyContactEmail = "daisy@example.com",
            DriversLicenseOnFile = true,
            SocialSecurityCardOnFile = false,
            Status = "Pending"
        });

        db.AddOpportunity(new Opportunity
        {
            OpportunityID = "O001",
            Name = "Beach Cleanup",
            Description = "Help clean up the beach.",
            Center = "Beach Center",
            Date = DateTime.Now.AddMonths(1),
            Duration = TimeSpan.FromHours(3), 
            MaximumVolunteers = 20,
            CurrentVolunteers = 5
        });

        db.AddOpportunity(new Opportunity
        {
            OpportunityID = "O002",
            Name = "Park Restoration",
            Description = "Help restore the local park.",
            Center = "Park Center",
            Date = DateTime.Now.AddMonths(2),
            Duration = TimeSpan.FromHours(4),
            MaximumVolunteers = 30,
            CurrentVolunteers = 10
        });
    }
}