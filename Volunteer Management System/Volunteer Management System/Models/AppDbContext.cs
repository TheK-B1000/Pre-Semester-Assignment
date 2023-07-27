using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Volunteer_Management_System.Models;
//using System.Collections.Generic;

namespace VolunteerManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Volunteer> Volunteer { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Opportunity> Opportunity { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }
}
