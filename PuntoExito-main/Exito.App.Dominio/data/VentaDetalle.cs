using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exito.App.Dominio
{
    public class VentaDetalle
    {
        public int Id {get; set;}

        public int VentaId {get; set;}
        [ForeignKey("VentaId")]
        public Venta Venta {get; set;}

        public int ConsolaId {get; set;}
        [ForeignKey("ConsolaId")]
        public Consola Consola {get; set;}
        
        public int Cantidad {get; set;}

    }

}