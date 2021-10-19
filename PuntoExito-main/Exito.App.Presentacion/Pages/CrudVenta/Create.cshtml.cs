using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudVenta
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
            string JsonOjb = HttpContext.Session.GetString("user");
            if(JsonOjb != null){
                return Page();
            }
            return RedirectToPage('/');
        }

        [BindProperty]
        public string CodigoMessage { get; set; }
        [BindProperty]
        public Venta Venta { get; set; }

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
            string JsonOjb = HttpContext.Session.GetString("user");
            if(JsonOjb != null){
                Empleado Person = JsonConvert.DeserializeObject<Empleado>(JsonOjb);
            

                Consola Consola = _context.Consolas.FirstOrDefault(c=>c.Codigo == Codigo);
                if(Consola == null){
                    CodigoMessage = "No se encontro ninguna consola con este codigo";
                    return Page();
                }

                Venta.EmpleadoId = Person.EmpleadoId;
                Venta.Total = Cantidad * Consola.precioVenta;
                Venta.Finalizada = true;
                Venta.ConsolaId = Consola.Id;
                Venta.Cantidad = Cantidad;
                Venta.Fecha = DateTime.Now;
                var ActualVenta = _context.Ventas.Add(Venta);

                // VentaDetalle.VentaId = ActualVenta.VentaId;
                // _context.VentaDetalles.Add(VentaDetalle);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
