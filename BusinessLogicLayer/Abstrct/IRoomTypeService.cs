using BusinessLogicLayer.Models.RoomTypeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstrct;

public interface IRoomTypeService
{
    Task<IEnumerable<RoomTypeModel>> GetAll();
}
