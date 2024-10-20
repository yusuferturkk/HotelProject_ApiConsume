using HotelProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Configuration
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Image).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(30);
            builder.Property(x => x.SocialMedia1).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SocialMedia2).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SocialMedia3).IsRequired().HasMaxLength(200);
        }
    }
}
