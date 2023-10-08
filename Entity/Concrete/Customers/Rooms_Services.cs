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
    public int RoomID { get; set; }
    public Rooms Rooms { get; set; }
    public Services Services { get; set; }
}
