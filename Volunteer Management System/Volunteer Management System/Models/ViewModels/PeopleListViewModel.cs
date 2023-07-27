using System.Collections.Generic;
using Volunteer_Management_System.Models;

using Volunteer_Management_System.Models.ViewModels;

namespace Volunteer_Management_System.Models.ViewModels
{
    public class PeopleListViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
