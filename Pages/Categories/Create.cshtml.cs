using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pricope_Delia_L2.Data;
using Pricope_Delia_L2.Models;

namespace Pricope_Delia_L2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Pricope_Delia_L2.Data.Pricope_Delia_L2Context _context;

        public CreateModel(Pricope_Delia_L2.Data.Pricope_Delia_L2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
