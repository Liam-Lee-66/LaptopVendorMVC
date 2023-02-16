using System.Drawing.Drawing2D;

namespace LaptopVendorMVC.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public Brand Brand { get; set; } 
        public double Price { get; set; }
        public int Year { get; set; }       
    }
}
