using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudEmpleado
{
    public class IndexModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public IndexModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleado { get;set; }

        // public Empleado User {get; set;}

        public async Task OnGetAsync()
        {
            Empleado = await _context.Empleados
                .Include(e => e.Rol)
                .Include(e => e.Sucursal).ToListAsync();
        }

        
    }
}
