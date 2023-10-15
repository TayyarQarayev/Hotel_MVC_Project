using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.ReservationsModels;

public class ReservationsModel
{
    public int? ID { get; set; }
    public int ReservationNumber { get; set; }
    public DateTime ReservationDate { get; set; }
    public int CustomerID { get; set; }
}
