using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pricope_Delia_L2.Data;
using Pricope_Delia_L2.Models;

namespace Pricope_Delia_L2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Pricope_Delia_L2.Data.Pricope_Delia_L2Context _context;

        public IndexModel(Pricope_Delia_L2.Data.Pricope_Delia_L2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
