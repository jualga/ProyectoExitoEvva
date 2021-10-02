using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudConsola
{
    public class CreateModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public CreateModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ControlId"] = new SelectList(_context.Controles, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Consola Consola { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Consolas.Add(Consola);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
