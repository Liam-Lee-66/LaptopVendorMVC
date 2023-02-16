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
    public class DeleteModel : PageModel
    {
        private readonly LaptopVendorMVC.Data.LaptopVendorContext _context;

        public DeleteModel(LaptopVendorMVC.Data.LaptopVendorContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Laptops == null)
            {
                return NotFound();
            }
            var laptop = await _context.Laptops.FindAsync(id);

            if (laptop != null)
            {
                Laptop = laptop;
                _context.Laptops.Remove(Laptop);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
