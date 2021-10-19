using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.Reports
{
    public class indexModel : PageModel
    {

        public IList<Compra> Compra { get; set; }
        public IList<Venta> Venta { get; set; }

        public IActionResult OnGet()
        {
            Exito.App.Persistencia.AppContext _context = new Exito.App.Persistencia.AppContext();
            Compra = _context.Compras
                .Include(c => c.Empleado)
                .Include(c => c.Consola)
                .Where(c=>c.Fecha > DateTime.Today.AddDays(-30))
                .ToList();
                
            Venta = _context.Ventas
                .Include(c => c.Empleado)
                .Include(c => c.Consola)
                .Where(c=>c.Fecha > DateTime.Today.AddDays(-30))
                .ToList();



            return Page();
        }
    }
}
