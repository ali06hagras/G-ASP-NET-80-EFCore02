using Assignment18.Configurations;
using Assignment18.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18.Contexts
{
    public class EventHubContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHub;Trusted_Connection=True;trustServerCertificate=true");
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>(O => 
            { 
                O.Property(O => O.Biography).HasMaxLength(500)
                                            .IsRequired(true)
                                            .HasColumnName("Bio");
                O.Property(O => O.Website).HasMaxLength(200);
            });
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new BadgeConfig());
        }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Badge> Badges { get; set; }
    }
}
