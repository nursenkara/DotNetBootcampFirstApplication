using Microsoft.EntityFrameworkCore;

namespace FirstApplication.Models
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
