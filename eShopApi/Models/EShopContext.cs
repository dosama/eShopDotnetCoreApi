using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eShopApi.Models
{
    public class EShopContext : DbContext
    {
        public EShopContext(DbContextOptions<EShopContext> options)
            : base(options)
        { }

        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Purshases> Purshases { get; set; }
        public DbSet<ProductsImages> ProductsImages { get; set; }

  
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

           
        }
    }
}
