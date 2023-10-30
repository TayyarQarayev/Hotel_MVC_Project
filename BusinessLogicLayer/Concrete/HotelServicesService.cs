using AutoMapper;
using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.HotelServicesModels;
using DataAccessLayer.Abstrct.CustomersInterfaces;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete;

public class HotelServicesService : IHotelServicesService
{
    private readonly IHotelServicesRepository _hotelServicesRepository;
    private readonly IMapper _mapper;
    public HotelServicesService(IHotelServicesRepository hotelServicesRepository, IMapper mapper)
    {
        _hotelServicesRepository = hotelServicesRepository;
        _mapper = mapper;
    }
    public async Task<bool> AddHotelServices(HotelServicesModel hotelServicesModel)
    {
        if (hotelServicesModel is null) 
        {
            return false;
        }
        var hotelServices = _mapper.Map<HotelServices>(hotelServicesModel);
        var adedData = await _hotelServicesRepository.AddAsync(hotelServices);
        await _hotelServicesRepository.SaveChanges();
        return true;
    }
    public async Task<IEnumerable<HotelServicesModel>> GetAll()
    {
        var hotelServicesModels = _mapper.Map<IEnumerable<HotelServicesModel>>(await _hotelServicesRepository.GetAll());
        return hotelServicesModels;
    }

    public async Task<HotelServicesModel> GetById(int id)
    {
        var hotelServicesModel = _mapper.Map<HotelServicesModel>(await _hotelServicesRepository.GetById(id));
        return hotelServicesModel;
    }

    public async Task<bool> Remove(int id)
    {
        var deletedHotelServices = await _hotelServicesRepository.GetById(id);
        if (deletedHotelServices is null) { return false; }
        _hotelServicesRepository.Remove(deletedHotelServices);
        await _hotelServicesRepository.SaveChanges();
        return true;
    }
}
