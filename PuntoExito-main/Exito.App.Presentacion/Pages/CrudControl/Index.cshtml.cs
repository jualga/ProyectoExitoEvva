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
    public class IndexModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public IndexModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        public IList<Control> Control { get;set; }

        public async Task OnGetAsync()
        {
            Control = await _context.Controles.ToListAsync();
        }
    }
}
