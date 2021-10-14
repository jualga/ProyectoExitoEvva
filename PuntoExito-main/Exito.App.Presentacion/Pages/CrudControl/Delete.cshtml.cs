using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudControl
{
    public class DeleteModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public DeleteModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Control Control { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Control = await _context.Controles.FirstOrDefaultAsync(m => m.Id == id);

            if (Control == null)
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

            Control = await _context.Controles.FindAsync(id);

            if (Control != null)
            {
                _context.Controles.Remove(Control);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
