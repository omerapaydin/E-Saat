using ESaat.Data.Abstract;
using ESaat.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContex>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"))); 


builder.Services.AddScoped<IProductRepository, EfProductRepository>();


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
