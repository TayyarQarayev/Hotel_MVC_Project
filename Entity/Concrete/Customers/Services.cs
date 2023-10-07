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
        Room_Service = new HashSet<Rooms_Services>();
    }
    public int ID { get; set; }
    public int RoomServiceID { get; set; }
    public int HotelServiceID { get; set; }
    public HotelServices HotelServices { get; set; }
    public RoomServices RoomServices { get; set; }
    public ICollection<Rooms_Services> Room_Service { get; set; }

}
