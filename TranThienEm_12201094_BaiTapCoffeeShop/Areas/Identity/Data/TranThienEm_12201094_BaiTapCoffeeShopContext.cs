using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Data;

public class TranThienEm_12201094_BaiTapCoffeeShopContext : IdentityDbContext<IdentityUser>
{
    public TranThienEm_12201094_BaiTapCoffeeShopContext(DbContextOptions<TranThienEm_12201094_BaiTapCoffeeShopContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
