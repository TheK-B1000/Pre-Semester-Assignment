using System.ComponentModel.DataAnnotations;


namespace Volunteer_Management_System.Models
{
    public class Admin
    {
        public string AdminID { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


    }
}
