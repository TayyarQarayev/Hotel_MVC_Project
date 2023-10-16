using BusinessLogicLayer.Models.HotelServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstrct;

public interface IHotelServicesService
{
    Task<IEnumerable<HotelServicesModel>> GetAll();
    Task<bool> AddHotelServices(HotelServicesModel hotelServicesModel);
}
