using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface IProducto
    {
        public Producto Save(Producto producto);
        public Producto Update(Producto producto);
        public List<Producto> FindAll();
        public Producto FindOne(int id);
        public bool Delete(int id);

        
    }

}