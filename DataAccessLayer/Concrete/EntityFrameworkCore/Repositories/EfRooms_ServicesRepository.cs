using DataAccessLayer.Abstrct.CustomersInterfaces;
using DataAccessLayer.Concrete.EntityFrameworkCore.Context;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Repositories;

public class EfRooms_ServicesRepository : EfGenericRepository<Rooms_Services>, IRooms_ServicesRepository
{
    public EfRooms_ServicesRepository(HotelEcommerceContext context) : base(context)
    {
    }
}
