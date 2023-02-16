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
    public class DetailsModel : PageModel
    {
        private readonly LaptopVendorMVC.Data.LaptopVendorContext _context;

        public DetailsModel(LaptopVendorMVC.Data.LaptopVendorContext context)
        {
            _context = context;
        }

      public Laptop Laptop { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Laptops == null)
            {
                return NotFound();
            }

            var laptop = await _context.Laptops.FirstOrDefaultAsync(m => m.Id == id);
            if (laptop == null)
            {
                return NotFound();
            }
            else 
            {
                Laptop = laptop;
            }
            return Page();
        }
    }
}
