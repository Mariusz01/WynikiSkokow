using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WynikiSkokow.Data;
using WynikiSkokow.Models;

namespace WynikiSkokow.Pages.Wynik
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly WynikiSkokow.Data.WynikiSkokowContext _context;

        public EditModel(WynikiSkokow.Data.WynikiSkokowContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Skoczek).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkoczekExists(Skoczek.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SkoczekExists(int id)
        {
            return _context.Skoczek.Any(e => e.ID == id);
        }
    }
}
