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
    public ReservationService(IReservationsRepository reservationsRepository)
    {
        _reservationsRepository = reservationsRepository;
    }

    public async Task<bool> AddReservations(ReservationsModel reservationsModel) 
    {
        if (reservationsModel is null) 
        {
            return false;
        }
        Reservations reservations = new()
        {
            ID = reservationsModel.ID ?? 0,
            ReservationNumber = reservationsModel.ReservationNumber,
            ReservationDate = reservationsModel.ReservationDate,
            CustomerID = reservationsModel.CustomerID
        };

        var adedData = await _reservationsRepository.AddAsync(reservations);
        await _reservationsRepository.SaveChanges();
        return true;
    }

    public async Task<IEnumerable<ReservationsModel>> GetAll()
    {
        List<ReservationsModel> reservationsModels = new List<ReservationsModel>();
        foreach (var reservations in await _reservationsRepository.GetAll())
        {
            ReservationsModel reservationsModel = new()
            {
                ID= reservations.ID,
                ReservationNumber = reservations.ReservationNumber,
                ReservationDate = reservations.ReservationDate,
                CustomerID = reservations.CustomerID
            };
            reservationsModels.Add(reservationsModel);
        }
        return reservationsModels;
    }
}
