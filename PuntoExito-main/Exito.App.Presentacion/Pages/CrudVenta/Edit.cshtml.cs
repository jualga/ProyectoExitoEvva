using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudVenta
{
    public class EditModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public EditModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Compra Compra { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Compra = await _context.Compras
                .Include(c => c.Empleado).FirstOrDefaultAsync(m => m.CompraId == id);

            if (Compra == null)
            {
                return NotFound();
            }
           ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "EmpleadoId", "EmpleadoId");
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

            _context.Attach(Compra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompraExists(Compra.CompraId))
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

        private bool CompraExists(int id)
        {
            return _context.Compras.Any(e => e.CompraId == id);
        }
    }
}
