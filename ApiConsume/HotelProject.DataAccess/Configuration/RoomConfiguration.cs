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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Number).IsRequired().HasMaxLength(20);
            builder.Property(x => x.CoverImage).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x => x.BedCount).IsRequired().HasMaxLength(25);
            builder.Property(x => x.BathCount).IsRequired().HasMaxLength(25);
            builder.Property(x => x.Wifi).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
        }
    }
}
