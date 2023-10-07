using Entity.Concrete.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Context.Config.CustomerConfig;

internal class HotelServicesConfig : IEntityTypeConfiguration<HotelServices>
{
    public void Configure(EntityTypeBuilder<HotelServices> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.HotelServicesName).IsRequired();

        builder.HasMany(x => x.Service)
               .WithOne(x => x.HotelServices)
               .HasForeignKey(x => x.HotelServiceID);
    }
}
