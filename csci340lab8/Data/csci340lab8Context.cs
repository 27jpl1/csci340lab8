using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace csci340lab8.Data
{
    public class csci340lab8Context : DbContext
    {
        public csci340lab8Context (DbContextOptions<csci340lab8Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Session> Session { get; set; } = default!;
    }
}
