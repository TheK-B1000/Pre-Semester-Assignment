﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Volunteer_Management_System.Models
{
    public class EFVolunteerRepository : IVolunteerRepository
    {
        private AppDbContext context;

        public EFVolunteerRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Volunteer> Volunteers => context.Volunteers;

        public void AddVolunteer(Volunteer volunteer)
        {
            context.Volunteers.Add(volunteer);
            context.SaveChanges();
        }

        public void UpdateVolunteer(Volunteer volunteer)
        {
            var volunteerToUpdate = context.Volunteers.FirstOrDefault(v => v.PersonID == volunteer.PersonID);
            if (volunteerToUpdate != null)
            {
                volunteerToUpdate.FirstName = volunteer.FirstName;
                volunteerToUpdate.LastName = volunteer.LastName;
                volunteerToUpdate.Username = volunteer.Username;
                volunteerToUpdate.Password = volunteer.Password;
                volunteerToUpdate.Address = volunteer.Address;
                volunteerToUpdate.PhoneNumbers = volunteer.PhoneNumbers;
                volunteerToUpdate.Email = volunteer.Email;
                volunteerToUpdate.Role = volunteer.Role;
                volunteerToUpdate.Centers = volunteer.Centers;
                volunteerToUpdate.SkillsOrInterests = volunteer.SkillsOrInterests;
                volunteerToUpdate.AvailabilityTimes = volunteer.AvailabilityTimes;
                volunteerToUpdate.EducationalBackground = volunteer.EducationalBackground;
                volunteerToUpdate.CurrentLicenses = volunteer.CurrentLicenses;
                volunteerToUpdate.EmergencyContactName = volunteer.EmergencyContactName;
                volunteerToUpdate.EmergencyContactPhone = volunteer.EmergencyContactPhone;
                volunteerToUpdate.EmergencyContactEmail = volunteer.EmergencyContactEmail;
                volunteerToUpdate.DriversLicenseOnFile = volunteer.DriversLicenseOnFile;
                volunteerToUpdate.SocialSecurityCardOnFile = volunteer.SocialSecurityCardOnFile;

                context.SaveChanges();
            }
        }


        public void DeleteVolunteer(string PersonID)
        {
            var volunteerToDelete = context.Volunteers.FirstOrDefault(v => v.PersonID == PersonID);
            if (volunteerToDelete != null)
            {
                context.Volunteers.Remove(volunteerToDelete);
                context.SaveChanges();
            }
        }

        public IEnumerable<Volunteer> FilterVolunteers(string filter)
        {
            return context.Volunteers.Where(v => v.FirstName.Contains(filter) || v.LastName.Contains(filter)).ToList();
        }

        public IEnumerable<Volunteer> SearchVolunteers(string query)
        {
            return context.Volunteers.Where(v => v.FirstName.Contains(query) || v.LastName.Contains(query)).ToList();
        }
    }
}
