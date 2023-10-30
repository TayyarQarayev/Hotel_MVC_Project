using AutoMapper;
using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.ReservationsModels;
using DataAccessLayer.Abstrct.CustomersInterfaces;
using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete;

public class ReservationService : IReservationService
{
    private readonly IReservationsRepository _reservationsRepository;
    private readonly IMapper _mapper;
    public ReservationService(IReservationsRepository reservationsRepository, IMapper mapper)
    {
        _reservationsRepository = reservationsRepository;
        _mapper = mapper;
    }

    public async Task<bool> AddReservations(ReservationsModel reservationsModel) 
    {
        if (reservationsModel is null) 
        {
            return false;
        }
        var reservations = _mapper.Map<Reservations>(reservationsModel);
        var adedData = await _reservationsRepository.AddAsync(reservations);
        await _reservationsRepository.SaveChanges();
        return true;
    }

    public async Task<IEnumerable<ReservationsModel>> GetAll()
    {
        var reservationsModels = _mapper.Map<IEnumerable<ReservationsModel>>(await _reservationsRepository.GetAll());
        return reservationsModels;
    }

    public async Task<ReservationsModel> GetById(int id)
    {
        var reservationsModel = _mapper.Map<ReservationsModel>(await _reservationsRepository.GetById(id));
        return reservationsModel;
    }

    public async Task<bool> Remove(int id)
    {
        var delededReservations = await _reservationsRepository.GetById(id);
        if (delededReservations is null) { return false; };
        _reservationsRepository.Remove(delededReservations);
        await _reservationsRepository.SaveChanges();
        return true;
    }
}
