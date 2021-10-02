using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudConsola
{
    public class DeleteModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public DeleteModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Consola Consola { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consola = await _context.Consolas
                .Include(c => c.Controles).FirstOrDefaultAsync(m => m.Id == id);

            if (Consola == null)
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

            Consola = await _context.Consolas.FindAsync(id);

            if (Consola != null)
            {
                _context.Consolas.Remove(Consola);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
