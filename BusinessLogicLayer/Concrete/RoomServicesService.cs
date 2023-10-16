using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.RoomServicesModels;
using DataAccessLayer.Abstrct.CustomersInterfaces;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete;

public class RoomServicesService : IRoomServicesService
{
    private readonly IRoomServicesRepository _roomServicesRepository;
    public RoomServicesService(IRoomServicesRepository roomServicesRepository)
    {
        _roomServicesRepository = roomServicesRepository;
    }
    public async Task<bool> AddRoomServices(RoomServicesModel roomServicesModel)
    {
        if (roomServicesModel is null)
        {
            return false;
        }
        RoomServices roomServices = new()
        {
            ID = roomServicesModel.ID ?? 0,
            RoomServicesName = roomServicesModel.RoomServicesName
        };
        var added = await _roomServicesRepository.AddAsync(roomServices);
        await _roomServicesRepository.SaveChanges();
        return true;
    }
    public async Task<IEnumerable<RoomServicesModel>> GetAll()
    {
        List<RoomServicesModel> roomServicesModels = new List<RoomServicesModel>();
        foreach (var roomServices in await _roomServicesRepository.GetAll())
        {
            RoomServicesModel roomServicesModel = new()
            {
                ID = roomServices.ID,
                RoomServicesName= roomServices.RoomServicesName
            };
            roomServicesModels.Add(roomServicesModel);
        }
        return roomServicesModels;
    }
}
