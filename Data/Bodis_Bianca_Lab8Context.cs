using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bodis_Bianca_Lab8.Models;

namespace Bodis_Bianca_Lab8.Data
{
    public class Bodis_Bianca_Lab8Context : DbContext
    {
        public Bodis_Bianca_Lab8Context (DbContextOptions<Bodis_Bianca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bodis_Bianca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bodis_Bianca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Bodis_Bianca_Lab8.Models.Category> Category { get; set; }
    }
}
