﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volunteer_Management_System.Models;

#nullable disable

namespace Volunteer_Management_System.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Volunteer_Management_System.Models.Opportunity", b =>
                {
                    b.Property<string>("OpportunityID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Center")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentVolunteers")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("MaximumVolunteers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OpportunityID");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("Volunteer_Management_System.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumbers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("People");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Volunteer_Management_System.Models.Admin", b =>
                {
                    b.HasBaseType("Volunteer_Management_System.Models.Person");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Volunteer_Management_System.Models.Volunteer", b =>
                {
                    b.HasBaseType("Volunteer_Management_System.Models.Person");

                    b.Property<string>("AvailabilityTimes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Centers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentLicenses")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DriversLicenseOnFile")
                        .HasColumnType("bit");

                    b.Property<string>("EducationalBackground")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillsOrInterests")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SocialSecurityCardOnFile")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Volunteer");
                });
#pragma warning restore 612, 618
        }
    }
}
