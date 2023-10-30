using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Models.CustomersModels;
using BusinessLogicLayer.Models.HotelServicesModels;
using BusinessLogicLayer.Models.ReservationsModels;
using BusinessLogicLayer.Models.RoomServicesModels;
using BusinessLogicLayer.Models.RoomsModels;
using BusinessLogicLayer.Models.RoomTypeModels;
using Entity.Concrete.Customers;
using HotelECommerce.Electronic.App_MVC.Areas.Admin.Models;
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
    private readonly IRoomsService _RoomsServices;
    public RoomsController(IRoomTypeService roomTypeService,
                           IReservationService reservationService,
                           ICustomersService customersService,
                           IRoomServicesService roomServicesServices,
                           IHotelServicesService hotelServicesServices,
                           IRoomsService roomsServices)
    {
        _RoomTypeService = roomTypeService;
        _ReservationsServices = reservationService;
        _CustomersService = customersService;
        _RoomServicesServices = roomServicesServices;
        _HotelServicesServices = hotelServicesServices;
        _RoomsServices = roomsServices;
    }
    public IActionResult Index()
    {
        return View();
    }
    // Rooms views
    [HttpGet]
    public async Task<IActionResult> AddRooms()
    {
        return View();
    }
    [HttpPost]
    public async Task<JsonResult> AddRooms([FromBody]RoomsModel roomsModel)
    {
        await _RoomsServices.Add(roomsModel);
        return Json(new {message="new Room Aded!"});
    }
    // RoomType views //
    public async Task<IActionResult> RoomType()
    {
        RoomTypeViewModel roomTypeViewModel = new();
        roomTypeViewModel.RoomTypeModels = await _RoomTypeService.GetAll();
        return View(roomTypeViewModel);
    }

    [HttpPost]         
    public async Task<IActionResult> AddRoomType(RoomTypeModel roomTypeModel)
    {
        if (ModelState.IsValid)
        {
            var result = _RoomTypeService.AddRoomType(roomTypeModel);
        }
        RoomTypeViewModel roomTypeViewModel = new();
        roomTypeViewModel.TypeName = roomTypeModel.TypeName;
        return RedirectToAction(nameof(RoomType),roomTypeViewModel);
    }
    // GetList
    public async Task<JsonResult> GetRoomTypeList()
    {
        var roomTypes = await _RoomTypeService.GetAll();
        return Json(roomTypes);
    }
    // End
    // Reservation views //
    public async Task<IActionResult> Reservations()
    {
        ReservationsViewModel reservationsViewModel = new();
        reservationsViewModel.ReservationsModels = await _ReservationsServices.GetAll();
        return View(reservationsViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AddReservations(ReservationsModel reservationsModel)
    {
        if (ModelState.IsValid)
        {
            var result = _ReservationsServices.AddReservations(reservationsModel);
        }
        ReservationsViewModel reservationsViewModel = new();
        reservationsViewModel.ReservationNumber = reservationsModel.ReservationNumber;
        reservationsViewModel.ReservationDate = reservationsModel.ReservationDate;
        reservationsViewModel.CustomerID = reservationsModel.CustomerID;
        return RedirectToAction(nameof(Reservations),reservationsViewModel);
    }
    public async Task<JsonResult> GetReservationsList()
    {
        var reservations = await _ReservationsServices.GetAll();
        return Json(reservations);
    }
    // End
    // Customers views
    public async Task<IActionResult> Customers()
    {
        CustomersViewModel customersViewModel = new();
        customersViewModel.CustomersModels = await _CustomersService.GetAll();
        return View(customersViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AddCustomers(CustomersModel customersModel)
    {
        if (ModelState.IsValid)
        {
            var result = _CustomersService.AddCustomers(customersModel);
        }
        CustomersViewModel customersViewModel = new();
        customersViewModel.FirstName = customersModel.FirstName;
        customersViewModel.LastName = customersModel.LastName;
        customersViewModel.DateOfBirth = customersModel.DateOfBirth;
        customersViewModel.ContactNO = customersModel.ContactNO;
        return RedirectToAction(nameof(Customers),customersViewModel);
    }
    // End
    // RoomServices views
    public async Task<IActionResult> RoomServices()
    {
        RoomServicesViewModel roomServicesViewModel = new();
        roomServicesViewModel.RoomServicesModels = await _RoomServicesServices.GetAll();
        return View(roomServicesViewModel);
    }
    [HttpPost]
    public async Task<IActionResult> AddRoomServices(RoomServicesModel roomServicesModel)
    {
        if (ModelState.IsValid)
        {
            var result = _RoomServicesServices.AddRoomServices(roomServicesModel);
        }
        RoomServicesViewModel roomServicesViewModel = new();
        roomServicesViewModel.RoomServicesName = roomServicesModel.RoomServicesName;
        return RedirectToAction(nameof(RoomServices),roomServicesViewModel);
    }
    public async Task<JsonResult> GetRoomServicesList()
    {
        var roomServices = await _RoomServicesServices.GetAll();
        return Json(roomServices);
    }
    // End
    // HotelServices views
    public async Task<IActionResult> HotelServices() 
    {
        HotelServicesViewModel hotelServicesViewModel = new();
        hotelServicesViewModel.HotelServicesModels = await _HotelServicesServices.GetAll();
        return View(hotelServicesViewModel);
    }
    [HttpPost]
    public async Task<IActionResult> AddHotelServices(HotelServicesModel hotelServicesModel) 
    {
        if (ModelState.IsValid)
        {
            var result = _HotelServicesServices.AddHotelServices(hotelServicesModel);
        }
        HotelServicesViewModel hotelServicesViewModel = new();
        hotelServicesViewModel.HotelServicesName = hotelServicesModel.HotelServicesName;
        return RedirectToAction(nameof(HotelServices),hotelServicesViewModel);
    }
    public async Task<JsonResult> GetHotelServicesList()
    {
        var hotelServices = await _HotelServicesServices.GetAll();
        return Json(hotelServices);
    }
    // End
    // HttpGet
    [HttpGet]
    public async Task<JsonResult> DeleteRoomType(int id)
    {
        var isDelete  =  await _RoomTypeService.Remove(id);
        if (isDelete) { return Json(new {message="Room Type is Deleted"}); }
        return Json(new { message = "Room Type isn't Deleted" });
    }
    [HttpGet]
    public async Task<JsonResult> DeleteRoomServices(int id) 
    {
        var isDelete = await _RoomServicesServices.Remove(id);
        if (isDelete) { return Json(new { message = "Room Services is Deleted" }); }
        return Json(new { message = "Room Services isn't Deleted" });
    }
    [HttpGet]
    public async Task<JsonResult> DeleteReservations(int id) 
    {
        var isDelete = await _ReservationsServices.Remove(id);
        if (isDelete) { return Json(new { message = "Reservations is Deleted" }); }
        return Json(new { message = "Reservations isn't Deleted" });
    }
    [HttpGet]
    public async Task<JsonResult> DeleteHotelServices(int id) 
    {
        var isDelete = await _HotelServicesServices.Remove(id);
        if (isDelete) { return Json(new { message = "Hotel Services is Deleted" }); }
        return Json(new { message = "Hotel Services isn't Deleted" });
    }
    [HttpGet]
    public async Task<JsonResult> DeleteCustomers(int id) 
    { 
        var isDelete = await _CustomersService.Remove(id);
        if (isDelete) { return Json(new { message = "Customers is Deleted" }); }
        return Json(new { message = "Customers isn't Deleted" });
    }
    // End
    // image
    [HttpPost]
    public async Task<JsonResult> UploadImage(IFormFile image)
    {
        try
        {
            if (image != null && image.Length>0)
            {
                return Json("");
            }
        }
        catch (Exception)
        {

            throw;
        }
        return Json("");
    }
    // End
}