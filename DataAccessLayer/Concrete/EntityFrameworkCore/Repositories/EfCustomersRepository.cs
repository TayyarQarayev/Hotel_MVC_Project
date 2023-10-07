using DataAccessLayer.Abstrct.CustomersInterfaces;
using DataAccessLayer.Concrete.EntityFrameworkCore.Context;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Repositories;

public class EfCustomersRepository : EfGenericRepository<Customers>, ICustomersRepository
{
    public EfCustomersRepository(HotelEcommerceContext context) : base(context)
    {
    }
}
