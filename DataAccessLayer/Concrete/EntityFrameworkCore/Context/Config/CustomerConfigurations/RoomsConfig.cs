using Entity.Concrete.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Context.Config.CustomerConfig;

internal class RoomsConfig : IEntityTypeConfiguration<Rooms>
{
    public void Configure(EntityTypeBuilder<Rooms> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.RoomNumber).IsRequired();
        builder.Property(x => x.RoomPrice).IsRequired();
        builder.Property(x => x.RoomTypeID).IsRequired();
        builder.Property(x => x.ReservationID).IsRequired();

        builder.HasOne(x => x.RoomType)
               .WithMany(x => x.Room)
               .HasForeignKey(x => x.RoomTypeID);

        builder.HasOne(x => x.Reservations)
               .WithMany(x => x.Room)
               .HasForeignKey(x => x.ReservationID);
    }
}
