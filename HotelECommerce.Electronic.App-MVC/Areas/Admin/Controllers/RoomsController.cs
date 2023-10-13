using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.RoomTypeModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Controllers;

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

    // RoomType viwes //
    public async Task<IActionResult> RoomType()
    {
        var RoomTypes = await _RoomTypeService.GetAll();
        return View(RoomTypes);
    }

    [HttpPost]
    public async Task<IActionResult> AddRoomType(RoomTypeModel roomTypeModel) 
    {
        var reult = _RoomTypeService.AddRoomType(roomTypeModel);
        return RedirectToAction(nameof(RoomType));
    }
}   // End 
