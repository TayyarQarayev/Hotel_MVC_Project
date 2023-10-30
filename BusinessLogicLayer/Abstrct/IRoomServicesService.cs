using BusinessLogicLayer.Models.RoomServicesModels;
using BusinessLogicLayer.Models.RoomTypeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstrct;

public interface IRoomServicesService
{
    Task<IEnumerable<RoomServicesModel>> GetAll();
    Task<bool> AddRoomServices(RoomServicesModel roomServicesModel);
    Task<RoomServicesModel> GetById(int id);
    Task<bool> Remove(int id);
}
