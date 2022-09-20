using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace Hiren_Patel_lab8.Data
{
    public class Hiren_Patel_lab8Context : DbContext
    {
        public Hiren_Patel_lab8Context (DbContextOptions<Hiren_Patel_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
