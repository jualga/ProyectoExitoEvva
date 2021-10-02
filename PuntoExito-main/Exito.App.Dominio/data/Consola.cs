using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exito.App.Dominio
{
    public class Consola : Producto
    {
        // public int CompraId {get; set;}
        // public string Nombre {get; set;}
        // public string Version {get; set;}
        // public string Fabricante {get; set;}
        // public int PrecioCompra {get; set;}
        // public int PrecioVenta {get; set;}
        public string Almacenamiento {get; set;}
        public string VelocidadRam {get; set;}
        public string VelocidadProcesamiento {get; set;}
        public TypoDisco TypoDisco {get; set;}

        public int ControlId {get; set;}
        [ForeignKey("ControlId")]

        public Control Controles {get; set;}
        // public VideoJuego VideoJuegos {get; set;}

    }

}