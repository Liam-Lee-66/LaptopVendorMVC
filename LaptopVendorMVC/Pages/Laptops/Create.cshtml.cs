using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LaptopVendorMVC.Data;
using LaptopVendorMVC.Models;

namespace LaptopVendorMVC.Pages.Laptops
{
    public class CreateModel : PageModel
    {
        private readonly LaptopVendorMVC.Data.LaptopVendorContext _context;

        public CreateModel(LaptopVendorMVC.Data.LaptopVendorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Laptop Laptop { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Laptops == null || Laptop == null)
            {
                return Page();
            }

            _context.Laptops.Add(Laptop);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
