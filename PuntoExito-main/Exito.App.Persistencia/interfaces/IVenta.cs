using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface IVenta

    {
        public Venta Save(Venta venta);
        public Venta Update(Venta venta);
        public List<Venta> FindAll();
        public Venta FindOne(int id);
        public bool Delete(int id);
        
    }

}