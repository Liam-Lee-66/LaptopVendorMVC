using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LaptopVendorMVC.Data;
using LaptopVendorMVC.Models;

namespace LaptopVendorMVC.Pages.Laptops
{
    public class IndexModel : PageModel
    {
        private readonly LaptopVendorMVC.Data.LaptopVendorContext _context;

        public IndexModel(LaptopVendorMVC.Data.LaptopVendorContext context)
        {
            _context = context;
        }

        public IList<Laptop> Laptop { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Laptops != null)
            {
                Laptop = await _context.Laptops.ToListAsync();
            }
        }
    }
}
