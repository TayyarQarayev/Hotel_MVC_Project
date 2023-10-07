using Entity.Concrete.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Context.Config.CustomerConfig;

internal class ServicesConfig : IEntityTypeConfiguration<Services>
{
    public void Configure(EntityTypeBuilder<Services> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.RoomServiceID).IsRequired();
        builder.Property(x => x.HotelServiceID).IsRequired();

        builder.HasOne(x => x.RoomServices)
               .WithMany(x => x.Service)
               .HasForeignKey(x => x.RoomServiceID);

        builder.HasOne(x => x.HotelServices)
               .WithMany(x => x.Service)
               .HasForeignKey(x => x.HotelServiceID);
    }
}
