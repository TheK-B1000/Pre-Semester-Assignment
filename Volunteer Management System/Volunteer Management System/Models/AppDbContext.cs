﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Volunteer_Management_System.Models;


namespace Volunteer_Management_System.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<Admin>("Admin")
                .HasValue<Volunteer>("Volunteer");
        }

    }
}
