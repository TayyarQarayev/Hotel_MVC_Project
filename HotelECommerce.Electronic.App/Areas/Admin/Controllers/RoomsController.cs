using Microsoft.AspNetCore.Mvc;

namespace HotelECommerce.Electronic.App.Areas.Admin.Controllers;

public class RoomsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
