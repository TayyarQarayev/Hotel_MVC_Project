using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Customers;


public class Services : IBaseTable
{
    public Services()
    {
        RoomServices = new HashSet<RoomServices>();
        HotelServices = new HashSet<HotelServices>();
    }
    public int ID { get; set; }
    public int RoomServiceID { get; set; }
    public int HotelServiceID { get; set; }
    public Rooms_Services Rooms_Services { get; set; }

    public ICollection<RoomServices> RoomServices { get; set; }
    public ICollection<HotelServices> HotelServices { get; set; }

}
