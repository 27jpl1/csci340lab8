using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using csci340lab8.Data;

namespace csci340lab8.Pages.Sessions
{
    public class IndexModel : PageModel
    {
        private readonly csci340lab8.Data.csci340lab8Context _context;

        public IndexModel(csci340lab8.Data.csci340lab8Context context)
        {
            _context = context;
        }

        public IList<Session> Session { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Games { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SessionGame { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Session
                        select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.GameTitle.Contains(SearchString));
            }

                Session = await movies.ToListAsync();
        }
    }
}
