using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volunteer_Management_System.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
42 
 public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}