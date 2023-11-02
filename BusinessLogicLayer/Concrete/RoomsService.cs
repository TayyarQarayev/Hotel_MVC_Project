using AutoMapper;
using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.RoomsModels;
using DataAccessLayer.Abstrct.CustomersInterfaces;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete;

public class RoomsService : IRoomsService
{
    private readonly IRoomsRepository _roomsRepository;
    private readonly IMapper _mapper;
    public RoomsService(IRoomsRepository roomsRepository,IMapper mapper)
    {
        _roomsRepository = roomsRepository;
        _mapper = mapper;
    }

    public async Task<bool> Add(RoomsModel roomsModel)
    {
        var rooms = _mapper.Map<Rooms>(roomsModel);
        await _roomsRepository.AddAsync(rooms);
        await _roomsRepository.SaveChanges();
        return true;
    }
}
