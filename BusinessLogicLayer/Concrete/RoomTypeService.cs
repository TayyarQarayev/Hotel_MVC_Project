using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.RoomTypeModels;
using DataAccessLayer.Abstrct.CustomersInterfaces;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete;

public class RoomTypeService : IRoomTypeService
{
    private readonly IRoomTypeRepository _roomTypeRepository;
    public RoomTypeService(IRoomTypeRepository roomTypeRepository)
    {
        _roomTypeRepository = roomTypeRepository;
    }

    public async Task<bool> AddRoomType(RoomTypeModel roomTypeModel)
    {
        if (roomTypeModel is null) 
        {
            return false;
        }

        RoomType roomType = new()
        {
            ID = roomTypeModel.ID ?? 0,
            TypeName = roomTypeModel.TypeName
        };

        var addedData = await _roomTypeRepository.AddAsync(roomType);

        await _roomTypeRepository.SaveChanges();
        return true;
    }

    public async Task<IEnumerable<RoomTypeModel>> GetAll()
    {
        List<RoomTypeModel>roomTypeModels = new List<RoomTypeModel>();
        foreach (var roomType in await _roomTypeRepository.GetAll())
        {
            RoomTypeModel roomTypeModel = new() 
            {
                ID = roomType.ID,
                TypeName = roomType.TypeName
            };
            roomTypeModels.Add(roomTypeModel);
        }
        return roomTypeModels;
    }
}
