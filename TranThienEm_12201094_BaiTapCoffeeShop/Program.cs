using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TranThienEm_12201094_BaiTapCoffeeShop.Data;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Services;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
///declare the service DI
builder.Services.AddDbContext<CoffeeshopDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("CoffeeShopDbContextConnection")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
///declare the service DI
builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddEntityFrameworkStores<CoffeeshopDbContext>();

builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
builder.Services.AddRazorPages();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
