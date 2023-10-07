using Entity.Concrete.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Context.Config.CustomerConfig;

internal class CusomersConfig : IEntityTypeConfiguration<Customers>
{
    public void Configure(EntityTypeBuilder<Customers> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.FirstName).IsRequired();
        builder.Property(x => x.LastName).IsRequired();
        builder.Property(x => x.ContactNO).IsRequired();

        builder.HasMany(x => x.Reservation)
               .WithOne(x => x.Customers)
               .HasForeignKey(x => x.CustomerID);
    }
}
