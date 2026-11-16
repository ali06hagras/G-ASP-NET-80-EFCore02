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
    public class BadgeConfig : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> B)
        {
            B.ToTable("EventBadges");
            B.Property(b => b.Tier)
             .HasConversion<string>();
        }
    }
}
