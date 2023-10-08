using Entity.Concrete.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Context.Config.CustomerConfig;

internal class Rooms_ServicesConfig : IEntityTypeConfiguration<Rooms_Services>
{
    public void Configure(EntityTypeBuilder<Rooms_Services> builder)
    {
        builder.HasKey(x => new { x.ServiceID, x.RoomsID });

        builder.HasOne(x => x.RoomsServices)
               .WithMany()
               .HasForeignKey(x => x.ServiceID);


        builder.HasOne(x => x.RoomsServices)
               .WithMany()
               .HasForeignKey(x => x.RoomsID);
    }
}
