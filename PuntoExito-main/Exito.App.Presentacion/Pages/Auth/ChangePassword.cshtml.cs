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


namespace Exito.App.Presentacion.Pages.Auth
{
    public class ChangePasswordMode : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public ChangePasswordMode(Exito.App.Persistencia.AppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        [BindProperty]
        public string Password1 { get; set; } = "";

        [BindProperty]
        public string Password2 { get; set; } = "";

        public async Task OnGetAsync(int? id)
        {
            Empleado = await _context.Empleados
                .Include(e => e.Rol)
                .Include(e => e.Sucursal).FirstOrDefaultAsync(m => m.EmpleadoId == id);

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Password1.Equals(Password2) && !Password1.Equals(""))
            {
                Empleado.Clave = Password1;
                _context.Attach(Empleado).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpleadoExists(Empleado.EmpleadoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToPage("./Login");
            }
            Console.WriteLine(Password1+"  : "+Password2);
            return Page();
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleados.Any(e => e.EmpleadoId == id);
        }
    }
}