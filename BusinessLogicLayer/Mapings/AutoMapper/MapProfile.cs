using AutoMapper;
using BusinessLogicLayer.Models.CustomersModels;
using BusinessLogicLayer.Models.HotelServicesModels;
using BusinessLogicLayer.Models.ReservationsModels;
using BusinessLogicLayer.Models.RoomServicesModels;
using BusinessLogicLayer.Models.RoomsModels;
using BusinessLogicLayer.Models.RoomTypeModels;
using Entity.Concrete.Customers;

namespace BusinessLogicLayer.Mapings.AutoMaper;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<RoomTypeModel,RoomType>().ReverseMap();
        CreateMap<RoomServicesModel,RoomServices>().ReverseMap();
        CreateMap<HotelServicesModel,HotelServices>().ReverseMap();
        CreateMap<ReservationsModel,Reservations>().ReverseMap();
        CreateMap<CustomersModel,Customers>().ReverseMap();
        CreateMap<RoomsModel,Rooms>().ReverseMap();
    }
}
