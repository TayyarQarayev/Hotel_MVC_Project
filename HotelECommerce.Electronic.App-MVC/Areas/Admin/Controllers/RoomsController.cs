using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.CustomersModels;
using BusinessLogicLayer.Models.HotelServicesModels;
using BusinessLogicLayer.Models.ReservationsModels;
using BusinessLogicLayer.Models.RoomServicesModels;
using BusinessLogicLayer.Models.RoomTypeModels;
using Entity.Concrete.Customers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelECommerce.Electronic.App_MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class RoomsController : Controller
{
    private readonly IRoomTypeService _RoomTypeService;
    private readonly IReservationService _ReservationsServices;
    private readonly ICustomersService _CustomersService;
    private readonly IRoomServicesService _RoomServicesServices;
    private readonly IHotelServicesService _HotelServicesServices;
    public RoomsController(IRoomTypeService roomTypeService,
                           IReservationService reservationService,
                           ICustomersService customersService,
                           IRoomServicesService roomServicesServices,
                           IHotelServicesService hotelServicesServices)
    {
        _RoomTypeService = roomTypeService;
        _ReservationsServices = reservationService;
        _CustomersService = customersService;
        _RoomServicesServices = roomServicesServices;
        _HotelServicesServices = hotelServicesServices;
    }
    public IActionResult Index()
    {
        return View();
    }
    // RoomType views //
    public async Task<IActionResult> RoomType()
    {
        var roomTypes = await _RoomTypeService.GetAll();
        return View(roomTypes);
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
        var reservations = await _ReservationsServices.GetAll();
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
    // RoomServices
    public async Task<IActionResult> RoomServices()
    {
        var roomServices = await _RoomServicesServices.GetAll();
        return View(roomServices);
    }
    [HttpPost]
    public async Task<IActionResult> AddRoomServices(RoomServicesModel roomServicesModel)
    {
        var result = _RoomServicesServices.AddRoomServices(roomServicesModel);
        return RedirectToAction(nameof(RoomServices));
    }
    // End
    // HotelServices views
    public async Task<IActionResult> HotelServices() 
    {
        var hotelServices = await _HotelServicesServices.GetAll();
        return View(hotelServices);
    }
    [HttpPost]
    public async Task<IActionResult> AddHotelServices(HotelServicesModel hotelServicesModel) 
    {
        var result = _HotelServicesServices.AddHotelServices(hotelServicesModel);
        return RedirectToAction(nameof(HotelServices));
    }
    // End
}