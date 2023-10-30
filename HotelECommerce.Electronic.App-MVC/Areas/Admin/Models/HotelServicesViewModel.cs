using BusinessLogicLayer.Models.HotelServicesModels;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Models;

public class HotelServicesViewModel
{
    public HotelServicesViewModel()
    {
        HotelServicesModels = new List<HotelServicesModel>();
    }
    public int? ID { get; set; }
    public string HotelServicesName { get; set; } = string.Empty;
    public IEnumerable<HotelServicesModel> HotelServicesModels { get; set; }
}
