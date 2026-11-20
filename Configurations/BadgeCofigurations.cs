using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02EFCore.Configurations
{
    internal class BadgeCofigurations : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
           builder.HasOne(A => A.Attendee)
                .WithOne(B => B.Badge)
                .HasForeignKey<Badge>(B => B.AttendeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
