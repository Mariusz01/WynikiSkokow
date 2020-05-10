using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WynikiSkokow.Data;
using WynikiSkokow.Models;

namespace WynikiSkokow.Pages.Wynik
{
    public class IndexModel : PageModel
    {
        private readonly WynikiSkokow.Data.WynikiSkokowContext _context;

        public IndexModel(WynikiSkokow.Data.WynikiSkokowContext context)
        {
            _context = context;
        }

        public IList<Skoczek> Skoczek { get;set; }

        public async Task OnGetAsync()
        {
            Skoczek = await _context.Skoczek.ToListAsync();
        }
    }
}
