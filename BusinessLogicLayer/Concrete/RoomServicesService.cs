using AutoMapper;
using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.RoomServicesModels;
using BusinessLogicLayer.Models.RoomTypeModels;
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
    private readonly IMapper _mapper;
    public RoomServicesService(IRoomServicesRepository roomServicesRepository, IMapper mapper)
    {
        _roomServicesRepository = roomServicesRepository;
        _mapper = mapper;
    }
    public async Task<bool> AddRoomServices(RoomServicesModel roomServicesModel)
    {
        if (roomServicesModel is null)
        {
            return false;
        }
        var roomServices = _mapper.Map<RoomServices>(roomServicesModel);
        var added = await _roomServicesRepository.AddAsync(roomServices);
        await _roomServicesRepository.SaveChanges();
        return true;
    }
    public async Task<IEnumerable<RoomServicesModel>> GetAll()
    {
        var roomServicesModels = _mapper.Map<IEnumerable<RoomServicesModel>>(await _roomServicesRepository.GetAll());
        return roomServicesModels;
    }

    public async Task<RoomServicesModel> GetById(int id)
    {
        var roomServicesModel = _mapper.Map<RoomServicesModel>(await _roomServicesRepository.GetById(id));
        return roomServicesModel;
    }
    public async Task<bool> Remove(int id)
    {
        var deletedRoomServices = await _roomServicesRepository.GetById(id);
        if (deletedRoomServices is null) {return false;}
        _roomServicesRepository.Remove(deletedRoomServices);
        await _roomServicesRepository.SaveChanges();
        return true;
    }
}
