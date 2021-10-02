using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exito.App.Dominio
{
    public class Venta
    {
        public int VentaID {get; set;}
        public string Fecha {get; set;} 
        public int Total {get; set;}

        public bool Finalizada {get; set;}
        public int EmpleadoId {get; set;}
        [ForeignKey("EmpleadoId")]
        public Empleado Empleado {get; set;}

    }

}