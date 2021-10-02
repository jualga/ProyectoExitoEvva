using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Exito.App.Dominio;

namespace Exito.App.Presentacion.Shared.Header
{
    public partial class HeaderModel : PageModel
    {
        Empleado User {get; set;} = new Empleado {Nombre="fabian"};
        public void OnGet()
        {
            var str = HttpContext.Session.GetString("user");
            User = JsonConvert.DeserializeObject<Empleado>(str);            
        }
    }
}
