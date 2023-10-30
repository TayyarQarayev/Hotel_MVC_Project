using AutoMapper;
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
    private readonly IMapper _mapper;
    public CustomersService(ICustomersRepository customersRepository, IMapper mapper)
    {
        _customersRepository = customersRepository;
        _mapper = mapper;
    }

    public async Task<bool> AddCustomers(CustomersModel customersModel)
    {
        if (customersModel is null)
        {
            return false;
        }
        var customers = _mapper.Map<Customers>(customersModel);
        var adedData = await _customersRepository.AddAsync(customers);
        await _customersRepository.SaveChanges();
        return true;
    }

    public async Task<IEnumerable<CustomersModel>> GetAll()
    {
        var customersModels = _mapper.Map<IEnumerable<CustomersModel>>(await _customersRepository.GetAll());
        return customersModels;
    }

    public async Task<CustomersModel> GetById(int id)
    {
        var customersModel = _mapper.Map<CustomersModel>(await _customersRepository.GetById(id));
        return customersModel;
    }

    public async Task<bool> Remove(int id)
    {
        var deletedCustomers = await _customersRepository.GetById(id);
        if (deletedCustomers is null) { return false; }
        _customersRepository.Remove(deletedCustomers);
        await _customersRepository.SaveChanges();
        return true;
    }
}
