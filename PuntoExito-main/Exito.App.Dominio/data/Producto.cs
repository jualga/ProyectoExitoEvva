namespace Exito.App.Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Version { get; set; }
        public string Fabricante { get; set; }
        public int precioCompra {get; set;}
        public int precioVenta {get; set;}
    }

}