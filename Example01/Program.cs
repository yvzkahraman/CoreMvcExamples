//program.cs

using Example01.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<ProductDbContext>();
builder.Services.AddDbContext<ProductDbContext>(opt =>
{
    opt.UseSqlServer("server=.\\SQLExpress; database=productdb; integrated security=true; TrustServerCertificate=true;");
});

//builder.Services.AddScoped(service => new ProductDbContext());

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});

app.Run();