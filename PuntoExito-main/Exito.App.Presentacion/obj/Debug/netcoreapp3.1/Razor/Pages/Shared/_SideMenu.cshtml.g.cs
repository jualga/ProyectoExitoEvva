#pragma checksum "C:\Users\Fabig\work-space\mintic\evva\ProyectoExitoEvva\PuntoExito-main\Exito.App.Presentacion\Pages\Shared\_SideMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa161bef72a2a4cd935eef95112550a17de7cbe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Exito.App.Presentacion.Pages.Shared.Pages_Shared__SideMenu), @"mvc.1.0.view", @"/Pages/Shared/_SideMenu.cshtml")]
namespace Exito.App.Presentacion.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Fabig\work-space\mintic\evva\ProyectoExitoEvva\PuntoExito-main\Exito.App.Presentacion\Pages\_ViewImports.cshtml"
using Exito.App.Presentacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Fabig\work-space\mintic\evva\ProyectoExitoEvva\PuntoExito-main\Exito.App.Presentacion\Pages\Shared\_SideMenu.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa161bef72a2a4cd935eef95112550a17de7cbe3", @"/Pages/Shared/_SideMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798fc6a453212ee0ccfd87bc48b7b12cd393c992", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__SideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Fabig\work-space\mintic\evva\ProyectoExitoEvva\PuntoExito-main\Exito.App.Presentacion\Pages\Shared\_SideMenu.cshtml"
  
    string name = @HttpContextAccessor.HttpContext.Session.GetString("user");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""side-menu"">
    <div class=""s-title"">
        <h2>Exito Dashboard</h2>
    </div>

    <div class=""s-menu-container"">
        <a href=""/CrudEmpleado/Create"" class=""s-menu-item"">
            Registrar empleado
        </a>
        <a href=""/CrudEmpleado"" class=""s-menu-item"">
            Registrar empleado
        </a>
        <a href=""/CrudEmpleado"" class=""s-menu-item"">
            Registrar empleado
        </a>
    </div>

</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591