using BusinessLogicLayer.Models.ReservationsModels;
using BusinessLogicLayer.Models.RoomTypeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstrct;

public interface IReservationService
{
    Task<IEnumerable<ReservationsModel>> GetAll();
    Task<bool> AddReservations(ReservationsModel reservationsModel);
    Task<ReservationsModel> GetById(int id);
    Task<bool> Remove(int id);
}
