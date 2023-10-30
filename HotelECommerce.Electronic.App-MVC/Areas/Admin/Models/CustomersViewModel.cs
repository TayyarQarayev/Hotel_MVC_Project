using BusinessLogicLayer.Models.CustomersModels;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Models;

public class CustomersViewModel
{
    public CustomersViewModel()
    {
        CustomersModels = new List<CustomersModel>();
    }
    public int? ID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string DateOfBirth { get; set; } = string.Empty;
    public string ContactNO { get; set; } = string.Empty;
    public IEnumerable<CustomersModel> CustomersModels { get; set; }
}
