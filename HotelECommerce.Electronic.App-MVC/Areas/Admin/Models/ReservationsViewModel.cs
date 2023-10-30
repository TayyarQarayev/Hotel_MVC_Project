using BusinessLogicLayer.Models.ReservationsModels;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Models;

public class ReservationsViewModel
{
    public ReservationsViewModel()
    {
        ReservationsModels = new List<ReservationsModel>();
    }
    public int? ID { get; set; }
    public int ReservationNumber { get; set; }
    public DateTime ReservationDate { get; set; }
    public int CustomerID { get; set; }
    public IEnumerable<ReservationsModel> ReservationsModels { get; set; }
}
