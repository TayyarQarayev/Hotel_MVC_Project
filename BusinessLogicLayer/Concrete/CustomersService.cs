using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.CustomersModels;
using DataAccessLayer.Abstrct.CustomersInterfaces;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete;

public class CustomersService : ICustomersService
{
    private readonly ICustomersRepository _customersRepository;
    public CustomersService(ICustomersRepository customersRepository)
    {
        _customersRepository = customersRepository;
    }

    public async Task<bool> AddCustomers(CustomersModel customersModel)
    {
        if (customersModel is null)
        {
            return false;
        }
        Customers customers = new()
        {
            ID = customersModel.ID ?? 0,
            FirstName = customersModel.FirstName,
            LastName = customersModel.LastName,
            ContactNO = customersModel.ContactNO,
            DateOfBirth = customersModel.DateOfBirth
        };

        var adedData = await _customersRepository.AddAsync(customers);
        await _customersRepository.SaveChanges();
        return true;
    }

    public async Task<IEnumerable<CustomersModel>> GetAll()
    {
        List<CustomersModel> customersModels = new List<CustomersModel>();
        foreach (var customers in await _customersRepository.GetAll())
        {
            CustomersModel customersModel = new()
            {
                ID = customers.ID,
                FirstName = customers.FirstName,
                LastName = customers.LastName,
                ContactNO = customers.ContactNO,
                DateOfBirth = customers.DateOfBirth
            };
            customersModels.Add(customersModel);
        }
        return customersModels;
    }
}
