using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Customers;

public class Rooms_Services : IBaseTable
{
    public int ServiceID { get; set; }
    public int RoomsID { get; set; }
    public RoomServices RoomsServices { get; set; }
    public HotelServices HotelServices { get; set; }
}
