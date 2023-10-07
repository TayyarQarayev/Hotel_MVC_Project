using DataAccessLayer.Abstrct.CustomersInterfaces;
using DataAccessLayer.Concrete.EntityFrameworkCore.Context;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore.Repositories;

public class EfReservationRepository : EfGenericRepository<Reservations>, IReservationsRepository
{
    public EfReservationRepository(HotelEcommerceContext context) : base(context)
    {
    }
}
