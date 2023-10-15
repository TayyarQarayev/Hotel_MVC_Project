using BusinessLogicLayer.Models.CustomersModels;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstrct;

public interface ICustomersService
{
    Task<IEnumerable<CustomersModel>> GetAll();
    Task<bool> AddCustomers(CustomersModel customersModel);
}
