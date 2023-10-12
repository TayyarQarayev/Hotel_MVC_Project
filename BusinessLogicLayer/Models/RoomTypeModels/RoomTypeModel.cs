using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.RoomTypeModels;

public class RoomTypeModel
{
    public int? ID { get; set; }
    public string TypeName { get; set; } = string.Empty;
}
