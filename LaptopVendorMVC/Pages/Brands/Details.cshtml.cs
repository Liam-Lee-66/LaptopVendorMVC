using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LaptopVendorMVC.Data;
using LaptopVendorMVC.Models;

namespace LaptopVendorMVC.Pages.Brands
{
    public class DetailsModel : PageModel
    {
        private readonly LaptopVendorMVC.Data.LaptopVendorContext _context;

        public DetailsModel(LaptopVendorMVC.Data.LaptopVendorContext context)
        {
            _context = context;
        }

      public Brand Brand { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Brands == null)
            {
                return NotFound();
            }

            var brand = await _context.Brands.FirstOrDefaultAsync(m => m.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            else 
            {
                Brand = brand;
            }
            return Page();
        }
    }
}
