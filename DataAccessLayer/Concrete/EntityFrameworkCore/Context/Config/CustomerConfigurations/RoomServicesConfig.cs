using Entity.Concrete.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Context.Config.CustomerConfig;

internal class RoomServicesConfig : IEntityTypeConfiguration<RoomServices>
{
    public void Configure(EntityTypeBuilder<RoomServices> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.RoomServicesName).IsRequired();

        builder.HasMany(x => x.Service)
               .WithOne(x => x.RoomServices)
               .HasForeignKey(x => x.RoomServiceID);
    }
}
