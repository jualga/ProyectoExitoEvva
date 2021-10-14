using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudCompra
{
    public class CreateModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public CreateModel(Exito.App.Persistencia.AppContext context)
        {
            _context = new Exito.App.Persistencia.AppContext();
        }

        public IActionResult OnGet()
        {
        ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "EmpleadoId", "Nombre");
            return Page();
        }

        [BindProperty]
        public Compra Compra { get; set; }

        [BindProperty]
        public CompraDetalle CompraDetalle { get; set; }

        [BindProperty]
        public List<Compra> CompraDetalles { get; set; }
        [BindProperty]
        public string Codigo { get; set; }
        [BindProperty]
        public int Cantidad { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Compras.Add(Compra);
            _context.CompraDetalles.Add(CompraDetalle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
