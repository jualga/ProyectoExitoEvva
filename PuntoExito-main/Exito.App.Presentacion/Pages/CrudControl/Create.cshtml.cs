using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.CrudControl
{
    public class CreateModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;
        private int defaultCode {get; set;} = 1001;

        public CreateModel(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Control Control { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var Response = _context.Controles.OrderByDescending(p => p.Id).FirstOrDefault();
            if(Response == null){
                Control.Codigo = ""+defaultCode;
            }else{
                Control.Codigo = ""+(int.Parse(Response.Codigo)+1);
            }
            _context.Controles.Add(Control);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
