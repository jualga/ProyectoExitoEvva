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

namespace Exito.App.Presentacion.Pages.CrudCompra
{
    public class IndexModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public IndexModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        public IList<Compra> Compra { get;set; }

        public async Task OnGetAsync()
        {
            string JsonOjb = HttpContext.Session.GetString("user");
            if(JsonOjb != null){
                Empleado Person = JsonConvert.DeserializeObject<Empleado>(JsonOjb);
                Compra = await _context.Compras
                    .Include(c => c.Empleado)
                    .Include(c => c.Consola)
                    .Where(c => c.Empleado.EmpleadoId == Person.EmpleadoId)
                    .ToListAsync();
            }
        }
    }
}
