using AutoMapper;
using Flights.BusinessLogic.Implementations;
using Flights.BusinessLogic.Interfaces;
using Flights.Common.Mapper;
using Flights.Model.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
builder.Services.AddTransient<IPlaneService, PlaneService>();
builder.Services.AddTransient<IBuyerService, BuyerService>();
builder.Services.AddTransient<IFlightService, FlightService>();
builder.Services.AddTransient<IPassengerService, PassengerService>();
builder.Services.AddTransient<ITicketService, TicketService>();
builder.Services.AddTransient<IEmailService, EmailService>();
var mappingConfig = new MapperConfiguration(mc => mc.AddProfile(new MapperProfile()));
IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
});


app.UseHttpsRedirection();
app.UseDefaultFiles();

app.UseStaticFiles();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
