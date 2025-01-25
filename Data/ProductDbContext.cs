using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> option):base(option)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Items> Itm { get; set; }


    }
}
