using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02EFCore.Configurations
{
    internal class EventConfigurations : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            //builder.HasOne(O => O.Organizer)
            //     .WithMany(E => E.Events)
            //     .HasForeignKey(E => E.OrganizerId)
            //     .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
