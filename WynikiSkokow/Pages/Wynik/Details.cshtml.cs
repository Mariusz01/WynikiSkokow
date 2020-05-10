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
    public class DetailsModel : PageModel
    {
        private readonly WynikiSkokow.Data.WynikiSkokowContext _context;

        public DetailsModel(WynikiSkokow.Data.WynikiSkokowContext context)
        {
            _context = context;
        }

        public Skoczek Skoczek { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Skoczek = await _context.Skoczek.FirstOrDefaultAsync(m => m.ID == id);

            if (Skoczek == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
