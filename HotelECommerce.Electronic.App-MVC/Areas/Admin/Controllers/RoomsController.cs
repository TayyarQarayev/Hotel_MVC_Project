using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.CustomersModels;
using BusinessLogicLayer.Models.ReservationsModels;
using BusinessLogicLayer.Models.RoomTypeModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class RoomsController : Controller
{
    private readonly IRoomTypeService _RoomTypeService;
    public RoomsController(IRoomTypeService roomTypeService)
    {
        _RoomTypeService = roomTypeService;
    }
    private readonly IReservationService _ReservationsServices;
    public RoomsController(IReservationService reservationService)
    {
        _ReservationsServices = reservationService;
    }
    private readonly ICustomersService _CustomersService;
    public RoomsController(ICustomersService customersService)
    {
        _CustomersService = customersService;
    }
    private readonly IRoomServicesService _RoomServices;
    public RoomsController(IRoomServicesService roomServicesService)
    {
        _RoomServices = roomServicesService;
    }
    private readonly IHotelServicesService _HotelServices;
    public RoomsController(IHotelServicesService hotelServicesService)
    {
        _HotelServices = hotelServicesService;
    }
    public IActionResult Index()
    {
        return View();
    }
    // RoomType views //
    public async Task<IActionResult> RoomType()
    {
        var RoomTypes = await _RoomTypeService.GetAll();
        return View(RoomTypes);
    }

    [HttpPost]
    public async Task<IActionResult> AddRoomType(RoomTypeModel roomTypeModel)
    {
        var result = _RoomTypeService.AddRoomType(roomTypeModel);
        return RedirectToAction(nameof(RoomType));
    }
    // End
    // Reservation views //
    public async Task<IActionResult> Reservations()
    {
        var reservations = await _RoomTypeService.GetAll();
        return View(reservations);
    }

    [HttpPost]
    public async Task<IActionResult> AddReservations(ReservationsModel reservationsModel)
    {
        var result = _ReservationsServices.AddReservations(reservationsModel);
        return RedirectToAction(nameof(Reservations));
    }
    // End
    // Customers views
    public async Task<IActionResult> Customers()
    {
        var customers = await _CustomersService.GetAll();
        return View(customers);
    }

    [HttpPost]
    public async Task<IActionResult> AddCustomers(CustomersModel customersModel)
    {
        var result = _CustomersService.AddCustomers(customersModel);
        return RedirectToAction(nameof(Customers));
    }
    // End
}