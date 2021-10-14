using System.Collections.Generic;

namespace Exito.App.Dominio
{
    public class DefaultData 
    {

        public static List<string> Roles {get; set;} = new List<string> {
             "Administrador de sistemas", 
             "Administrador de Ventas", 
             "Administrador de compras",  
             "Vendedor"
        };

        public static List<string> Sucursales {get; set;} = new List<string> {
             "Sucursal A", 
             "Sucursal B", 
             "Sucursal C", 
             "Sucursal D", 
             
        };
        public static List<string> TipoDiscos {get; set;} = new List<string> {
             "SSD", 
             "HDD", 
             "BOTH",  
        };
        
    }

}