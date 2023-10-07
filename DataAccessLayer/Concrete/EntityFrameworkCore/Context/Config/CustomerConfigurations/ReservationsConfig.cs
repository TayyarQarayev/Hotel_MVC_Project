using Entity.Concrete.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Context.Config.CustomerConfig;

internal class ReservationsConfig : IEntityTypeConfiguration<Reservations>
{
    public void Configure(EntityTypeBuilder<Reservations> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ReservationNumber).IsRequired();
        builder.Property(x => x.ReservationDate).IsRequired();
        builder.Property(x => x.CustomerID).IsRequired();

        builder.HasMany(x => x.Room)
               .WithOne(x => x.Reservations)
               .HasForeignKey(x => x.ReservationID);
    }
}
