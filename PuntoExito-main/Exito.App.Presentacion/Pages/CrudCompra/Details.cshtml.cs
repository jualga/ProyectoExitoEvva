using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudCompra
{
    public class DetailsModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public DetailsModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
