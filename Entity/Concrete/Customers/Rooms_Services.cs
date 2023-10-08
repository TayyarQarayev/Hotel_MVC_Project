using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Customers;

public class Rooms_Services : IBaseTable
{
    public Rooms_Services()
    {
        Services = new HashSet<Services>();
    }
    public int ServiceID { get; set; }
    public int RoomsID { get; set; }
    public Rooms Rooms { get; set; }
    public ICollection<Services> Services { get; set; }
}
