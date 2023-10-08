using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Customers;

public class Reservations : IBaseTable
{
    public Reservations()
    {
        Rooms = new HashSet<Rooms>();
    }
    public int ID { get; set; }
    public int ReservationNumber { get; set; }
    public DateTime ReservationDate { get; set; }
    public int CustomerID { get; set; }
    public Customers Customers { get; set; }
    public ICollection<Rooms> Rooms { get; set; }
}
