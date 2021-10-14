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

namespace Exito.App.Presentacion.Pages.CrudConsola
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
        ViewData["ControlId"] = new SelectList(_context.Controles, "Id", "Nombre");
            return Page();
        }

        [BindProperty]
        public Consola Consola { get; set; }

        [BindProperty]
        public string Codigo { get; set; }
        [BindProperty]
        public string CodigoMessage { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            Control Control = _context.Controles.FirstOrDefault(c=>c.Codigo == Codigo);
            if(Control == null){
                CodigoMessage = "Codigo invalido";
                return Page();
            }


            var Response = _context.Consolas.OrderByDescending(p => p.Id).FirstOrDefault();
            if(Response == null){
                Consola.Codigo = ""+1001;
            }else{
                Consola.Codigo = ""+(int.Parse(Response.Codigo)+1);
            }


            Consola.ControlId = Control.Id;
            _context.Consolas.Add(Consola);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
