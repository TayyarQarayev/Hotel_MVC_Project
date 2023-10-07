using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrct.CustomersInterfaces;

public interface ICustomersRepository : IGenericRepository<Customers>
{
}
