using Microsoft.AspNetCore.Mvc;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
