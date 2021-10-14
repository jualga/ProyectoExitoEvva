using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudVideoJuegos
{
    public class DeleteModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public DeleteModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VideoJuego VideoJuego { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VideoJuego = await _context.VideoJuegos.FirstOrDefaultAsync(m => m.Id == id);

            if (VideoJuego == null)
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

            VideoJuego = await _context.VideoJuegos.FindAsync(id);

            if (VideoJuego != null)
            {
                _context.VideoJuegos.Remove(VideoJuego);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
