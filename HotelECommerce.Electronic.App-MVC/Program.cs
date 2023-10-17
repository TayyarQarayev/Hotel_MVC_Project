using BusinessLogicLayer.Abstrct;
using BusinessLogicLayer.Concrete;
using DataAccessLayer.Abstrct.CustomersInterfaces;
using DataAccessLayer.Concrete.EntityFrameworkCore.Context;
using DataAccessLayer.Concrete.EntityFrameworkCore.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<HotelEcommerceContext>();
// RoomType
builder.Services.AddScoped<IRoomTypeService, RoomTypeService>();
builder.Services.AddScoped<IRoomTypeRepository, EfRoomTypeRepository>();
// Reservations
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IReservationsRepository, EfReservationRepository>();
// Customers
builder.Services.AddScoped<ICustomersRepository, EfCustomersRepository>();
builder.Services.AddScoped<ICustomersService, CustomersService>();
// RoomServices
builder.Services.AddScoped<IRoomServicesRepository, EfRoomServicesRepository>();
builder.Services.AddScoped<IRoomServicesService, RoomServicesService>();
//HotelServices
builder.Services.AddScoped<IHotelServicesRepository, EfHotelServicesRepository>();
builder.Services.AddScoped<IHotelServicesService, HotelServicesService>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "Admin",
      pattern: "{area:exists}/{controller=Rooms}/{action=Index}/{id?}"
    );
});
app.Run();
