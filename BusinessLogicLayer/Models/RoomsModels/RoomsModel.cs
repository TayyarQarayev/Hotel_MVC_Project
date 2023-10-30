using Entity.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.RoomsModels;

public class RoomsModel
{
    public int ID { get; set; }
    public int RoomNumber { get; set; }
    public int RoomPrice { get; set; }
    public int GuestsCount { get; set; }
    public int ChilderenCount { get; set; }
    public decimal RoomSize { get; set; }
    public int RoomTypeID { get; set; }
    public int ReservationID { get; set; }
    public RoomType RoomType { get; set; }
    public Reservations Reservations { get; set; }
    public ICollection<Rooms_Services> Rooms_Services { get; set; }
}
