using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volunteer_Management_System.Models
{
    public interface IVolunteerRepository
    {
        IEnumerable<Volunteer> Volunteers { get; }
        void AddVolunteer(Volunteer volunteer);
        void UpdateVolunteer(Volunteer volunteer);
        void DeleteVolunteer(string PersonID);
        IEnumerable<Volunteer> FilterVolunteers(string filter);
        IEnumerable<Volunteer> SearchVolunteers(string query);
    }
}
