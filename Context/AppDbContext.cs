using Assignment02EFCore.Configurations;
using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02EFCore.Context
{
    internal class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ; Database=Assignment2;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>()
                .HasOne(E => E.Organizer)
                .WithMany(O => O.Events)
                .HasForeignKey(E => E.OrganizerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.ApplyConfiguration(new OrganizerProfileConfigurations());
            modelBuilder.ApplyConfiguration(new BadgeCofigurations());
        }


        
    }

    
}
  