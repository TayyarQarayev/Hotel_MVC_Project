using Entity.Concrete.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Context.Config.CustomerConfig;

internal class RoomTypeConfig : IEntityTypeConfiguration<RoomType>
{
    public void Configure(EntityTypeBuilder<RoomType> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.TypeName);

        builder.HasMany(x => x.Room)
               .WithOne(x => x.RoomType)
               .HasForeignKey(x => x.RoomTypeID);
    }
}
