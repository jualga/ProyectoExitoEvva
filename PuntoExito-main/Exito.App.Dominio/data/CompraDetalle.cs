using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exito.App.Dominio
{
    public class CompraDetalle
    {
        public int Id {get; set;}
        public int CompraId {get; set;}
        [ForeignKey("CompraId")]
        public Compra Compra {get; set;}

        public int ConsolaId {get; set;}
        [ForeignKey("ConsolaId")]

        public Consola Consola {get; set;}
        public int Cantidad {get; set;}

    }

}