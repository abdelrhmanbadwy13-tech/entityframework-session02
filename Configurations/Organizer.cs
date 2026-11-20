using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02EFCore.Configurations
{
    internal class OrganizerConfigurations : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
           
        }
    }
}
