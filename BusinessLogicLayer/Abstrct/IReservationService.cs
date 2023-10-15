using BusinessLogicLayer.Models.ReservationsModels;
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
}
