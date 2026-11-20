using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02EFCore.Configurations
{
    internal class OrganizerProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasOne(O => O.Organizer)
                           .WithOne(OP => OP.OrganizerProfile)
                           .HasForeignKey<OrganizerProfile>(OP => OP.OrganizerId)
                           .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
