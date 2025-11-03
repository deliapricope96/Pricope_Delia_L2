using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pricope_Delia_L2.Models;

namespace Pricope_Delia_L2.Data
{
    public class Pricope_Delia_L2Context : DbContext
    {
        public Pricope_Delia_L2Context (DbContextOptions<Pricope_Delia_L2Context> options)
            : base(options)
        {
        }

        public DbSet<Pricope_Delia_L2.Models.Book> Book { get; set; } = default!;
        public DbSet<Pricope_Delia_L2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
