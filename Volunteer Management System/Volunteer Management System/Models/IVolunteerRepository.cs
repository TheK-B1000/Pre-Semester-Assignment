using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volunteer_Management_System.Models
{
    public interface IVolunteerRepository
    {
        IEnumerable<Volunteer> Volunteers { get; }
    }
}
