using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.RoomTypeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete;

public class RoomTypeService : IRoomTypeService
{
    public Task<IEnumerable<RoomTypeModel>> GetAll()
    {
        throw new NotImplementedException();
    }
}
