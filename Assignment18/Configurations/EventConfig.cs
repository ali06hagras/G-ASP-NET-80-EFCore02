using Assignment18.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18.Configurations
{
    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> E)
        {
            E.Property(E => E.Title).HasMaxLength(200)
                                    .IsRequired(true);
            E.Property(E => E.Description).HasMaxLength(500);
        }
    }
}
