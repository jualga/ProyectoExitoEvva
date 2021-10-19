using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion.Pages.Setting
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public string Message {get; set;}
        
        public IActionResult OnGet()
        {
            Exito.App.Persistencia.AppContext _context = new Exito.App.Persistencia.AppContext();

            var res = _context.Roles.FirstOrDefault();

            if(res == null){
            List<Rol> Roles =  new List<Rol>();
            List<Sucursal> Sucursales =  new List<Sucursal>();
            List<TypoDisco> TypoDiscos =  new List<TypoDisco>();
            foreach (String rol in DefaultData.Roles)
            {
                Roles.Add(new Rol{Nombre = rol});
            } 

            foreach (String sucursal in DefaultData.Sucursales)
            {
                Sucursales.Add(new Sucursal{Nombre = sucursal});
            } 

            foreach (String discos in DefaultData.TipoDiscos)
            {
                TypoDiscos.Add(new TypoDisco{Nombre = discos});
            }

            _context.TypoDiscos.AddRange(TypoDiscos);
            _context.Sucursales.AddRange(Sucursales);
            _context.Roles.AddRange(Roles);

            // var rolr = _context.Roles.FirstOrDefault(r=>r.Nombre.Equals("Administrador de sistemas"));
            // var sucursalr = _context.Sucursales.FirstOrDefault(r=>r.Nombre.Equals("Sucursal A"));
            // _context.Empleados.Add(new Empleado{ Nombre = "Admin", Cedula = "12345678", Usuario="Admin", Clave = "Admin", RolId = rolr.RolId, SucursalId = sucursalr.SucursalId });
            _context.SaveChanges();

            Message = "Data saved";
            }
            return RedirectToPage("/Index");

        }
    }
}
