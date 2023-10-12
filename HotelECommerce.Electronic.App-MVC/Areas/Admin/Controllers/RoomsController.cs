using BusinessLogicLayer.Abstrct;
using Microsoft.AspNetCore.Mvc;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomsController : Controller
    {
        private readonly IRoomTypeService _RoomTypeService;

        public RoomsController(IRoomTypeService roomTypeService)
        {
            _RoomTypeService = roomTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RoomType()
        {
            return View();
        }
    }
}
