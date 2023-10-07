using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Customers;

public class RoomType : IBaseTable
{
    public RoomType()
    {
        Room = new HashSet<Rooms>();
    }
    public int ID { get; set; }
    public string TypeName { get; set; } = string.Empty;
    public ICollection<Rooms> Room { get; set; }

}
