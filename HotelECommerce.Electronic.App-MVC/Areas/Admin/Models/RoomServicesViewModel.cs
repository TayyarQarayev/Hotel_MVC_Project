using BusinessLogicLayer.Models.RoomServicesModels;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Models
{
    public class RoomServicesViewModel
    {
        public RoomServicesViewModel()
        {
            RoomServicesModels = new List<RoomServicesModel>();
        }
        public int? ID { get; set; }
        public string RoomServicesName { get; set; } = string.Empty;
        public IEnumerable<RoomServicesModel> RoomServicesModels { get; set; }
    }
}
