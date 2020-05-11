using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WynikiSkokow.Data;
using WynikiSkokow.Models;

namespace WynikiSkokow.Pages.Wynik
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly WynikiSkokow.Data.WynikiSkokowContext _context;

        public CreateModel(WynikiSkokow.Data.WynikiSkokowContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Skoczek Skoczek { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Skoczek.Add(Skoczek);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
