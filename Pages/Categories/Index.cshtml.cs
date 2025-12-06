using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pricope_Delia_L2.Data;
using Pricope_Delia_L2.Models;
using Pricope_Delia_L2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pricope_Delia_L2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Pricope_Delia_L2.Data.Pricope_Delia_L2Context _context;

        public IndexModel(Pricope_Delia_L2.Data.Pricope_Delia_L2Context context)
        {
            _context = context;
        }

        //public IList<Category> Category { get;set; } = default!;

        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
            .Include(bc => bc.BookCategories)
            .ThenInclude(b => b.Book)
            .ThenInclude(a => a!.Author)
            .OrderBy(i => i.CategoryName)
            .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                    .Where(i => i.ID == id.Value).Single();
                CategoryData.Books = category.BookCategories!
                    .Select(bc => bc.Book!)
                    .ToList();
            }

        }
    }
}
