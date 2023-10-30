using AutoMapper;
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
    private readonly IMapper _mapper;
    public RoomTypeService(IRoomTypeRepository roomTypeRepository, IMapper mapper)
    {
        _roomTypeRepository = roomTypeRepository;
        _mapper = mapper;
    }

    public async Task<bool> AddRoomType(RoomTypeModel roomTypeModel)
    {
        if (roomTypeModel is null) 
        {
            return false;
        }
        var roomType = _mapper.Map<RoomType>(roomTypeModel);
        var addedData = await _roomTypeRepository.AddAsync(roomType);
        await _roomTypeRepository.SaveChanges();
        return true;
    }
    public async Task<IEnumerable<RoomTypeModel>> GetAll()
    {
        var roomTypeModels = _mapper.Map<IEnumerable<RoomTypeModel>>(await _roomTypeRepository.GetAll());
        return roomTypeModels;
    }

    public async Task<RoomTypeModel> GetById(int id)
    {
        var roomTypeModel = _mapper.Map<RoomTypeModel>(await _roomTypeRepository.GetById(id));
        return roomTypeModel;
    }

    public async Task<bool> Remove(int id)
    {
        var deletedRoomType = await _roomTypeRepository.GetById(id);
        if (deletedRoomType is null) { return false; }
        _roomTypeRepository.Remove(deletedRoomType);
        await _roomTypeRepository.SaveChanges();
        return true;
    }
}
