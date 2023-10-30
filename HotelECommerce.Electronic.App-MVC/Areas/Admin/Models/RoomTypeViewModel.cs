using BusinessLogicLayer.Models.RoomTypeModels;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Models;

public class RoomTypeViewModel
{
    public RoomTypeViewModel()
    {
        RoomTypeModels = new List<RoomTypeModel>();
    }
    public int? ID { get; set; }
    public string TypeName { get; set; } = string.Empty;
    public IEnumerable<RoomTypeModel> RoomTypeModels { get; set; }
}
