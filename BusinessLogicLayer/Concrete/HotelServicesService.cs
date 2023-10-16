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
    public HotelServicesService(IHotelServicesRepository hotelServicesRepository)
    {
        _hotelServicesRepository = hotelServicesRepository;
    }
    public async Task<bool> AddHotelServices(HotelServicesModel hotelServicesModel)
    {
        if (hotelServicesModel is null) 
        {
            return false;
        }
        HotelServices hotelServices = new()
        {
            ID = hotelServicesModel.ID,
            HotelServicesName = hotelServicesModel.HotelServicesName
        };
        var adedData = await _hotelServicesRepository.AddAsync(hotelServices);
        await _hotelServicesRepository.SaveChanges();
        return true;
    }
    public async Task<IEnumerable<HotelServicesModel>> GetAll()
    {
        List<HotelServicesModel> hotelServicesModels = new List<HotelServicesModel>();
        foreach (var hotelServices in await _hotelServicesRepository.GetAll())
        {
            HotelServicesModel hotelServicesModel = new()
            {
                ID = hotelServices.ID,
                HotelServicesName = hotelServices.HotelServicesName
            };
            hotelServicesModels.Add(hotelServicesModel);
        }
        return hotelServicesModels;
    }
}
