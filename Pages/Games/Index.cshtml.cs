using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NAssignment_4.Data;
using NAssignment_4.Models;

namespace NAssignment_4.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly NAssignment_4.Data.AppDbContext _context;

        public IndexModel(NAssignment_4.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
