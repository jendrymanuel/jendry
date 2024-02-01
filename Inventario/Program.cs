using Inventario.Data;
using Inventario.Data.Context;
using Inventario.Data.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddScoped<IMyDbContext,MyDbContext>();
builder.Services.AddScoped<IProductoServices,ProductoServices>();
builder.Services.AddScoped<IProveedorServices,ProveedorServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
