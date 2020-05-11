using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WynikiSkokow.Data;
using WynikiSkokow.Models;

namespace WynikiSkokow.Pages.Wynik
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly WynikiSkokow.Data.WynikiSkokowContext _context;

        public DeleteModel(WynikiSkokow.Data.WynikiSkokowContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Skoczek = await _context.Skoczek.FindAsync(id);

            if (Skoczek != null)
            {
                _context.Skoczek.Remove(Skoczek);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
