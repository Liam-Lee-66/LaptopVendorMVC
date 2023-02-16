using LaptopVendorMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace LaptopVendorMVC.Data
{
    public class LaptopVendorContext : DbContext
    {
        public DbSet<Laptop> Laptops { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=LaptopVendor;Integrated Security=false;User ID=SA;Password=MyPass@word; TrustServerCertificate=True;");
        }
    }
}
