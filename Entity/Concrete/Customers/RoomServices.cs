using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Customers;

public class RoomServices : IBaseTable
{
    public int ID { get; set; }
    public string RoomServicesName { get; set; } = string.Empty;
    public Services Services { get; set; }
}
