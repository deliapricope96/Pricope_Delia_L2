using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pricope_Delia_L2.Data;
using Pricope_Delia_L2.Models;

namespace Pricope_Delia_L2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Pricope_Delia_L2.Data.Pricope_Delia_L2Context _context;

        public DetailsModel(Pricope_Delia_L2.Data.Pricope_Delia_L2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
