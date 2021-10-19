using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exito.App.Dominio
{
    public class Compra
    {
        public int CompraId {get; set;}
        public DateTime Fecha {get; set;} 
        public int Total {get; set;}
        public bool Finalizada {get; set;}
        public int EmpleadoId {get; set;}
        [ForeignKey("EmpleadoId")]
        public Empleado Empleado {get; set;}
        public int ConsolaId {get; set;}
        [ForeignKey("ConsolaId")]
        public Consola Consola {get; set;}
        
        public int Cantidad {get; set;}

    }

} 