using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exito.App.Dominio;
using Exito.App.Persistencia;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Exito.App.Presentacion.Pages.LogIn
{
    public class LoingModel : PageModel
    {
        private readonly Exito.App.Persistencia.AppContext _context;

        public LoingModel(Exito.App.Persistencia.AppContext context)
        {
            _context = new Exito.App.Persistencia.AppContext();
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        [BindProperty]
        public String Mensaje { get; set; } = "";

        public async Task<IActionResult> OnPostAsync()
        {
            // if (Usuario == null && passowrd == null)
            // {
            //     return NotFound();
            // }
            if (Empleado == null)
            {
                return NotFound();
            }

            Empleado EmpleadoFound = await _context.Empleados
                .Include(e => e.Rol)
                .Include(e => e.Sucursal).FirstOrDefaultAsync(m => m.Usuario == this.Empleado.Usuario);

            if (EmpleadoFound != null)
            {
                if (EmpleadoFound.Cedula == EmpleadoFound.Clave)
                {
                    HttpContext.Session.SetString("UId", EmpleadoFound.EmpleadoId.ToString());
                    return RedirectToPage("./ChangePassword", new { id = EmpleadoFound.EmpleadoId });
                    // Console.WriteLine(EmpleadoFound.Nombre);
                }
                if (EmpleadoFound.Clave == this.Empleado.Clave)
                {
                    var str = JsonConvert.SerializeObject(EmpleadoFound);
                    HttpContext.Session.SetString("user", str);
                    if(EmpleadoFound.Rol.Nombre.Equals("Administrador de sistemas"))
                        return RedirectToPage("../CrudEmpleado/Index");
                    if(EmpleadoFound.Rol.Nombre.Equals("Administrador de Ventas"))
                        return RedirectToPage("../CrudVentas/Index");
                    if(EmpleadoFound.Rol.Nombre.Equals("Administrador de compras"))
                        return RedirectToPage("../CrudCompra/Index");
                    if(EmpleadoFound.Rol.Nombre.Equals("Vendedor"))
                        return RedirectToPage("../CrudVenta/Index");
                    // Console.WriteLine(EmpleadoFound.Nombre);
                    // Console.WriteLine(HttpContext.Session.GetString("user"));
                }

            }
            Mensaje = "Usuario o contraseña incorrectos";

            return Page();
            //    ViewData["RolId"] = new SelectList(_context.Roles, "RolId", "Nombre");
            //    ViewData["SucursalId"] = new SelectList(_context.Sucursales, "SucursalId", "Nombre");

        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        // public async Task<IActionResult> OnPostAsync()
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return Page();
        //     }

        //     _context.Attach(Empleado).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!EmpleadoExists(Empleado.EmpleadoId))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return RedirectToPage("./Index");
        // }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleados.Any(e => e.EmpleadoId == id);
        }
    }
}
