using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volunteer_Management_System.Models
{
    public class FakePersonRepository : IPersonRepository
    {
        public IEnumerable<Person> People => new List<Person>
        {
            new Person() { FirstName = "Corey", LastName = "Norman", Username = "Kratos", Password = "hogwarts1", Address = "115 Knights Lane, Jacksonville, Fl 32259", PhoneNumbers = "904-265-8671", Email = "corey101@gmail.com", PersonID = "a1234567", Role = "Admin"  }
        };
    }
}
