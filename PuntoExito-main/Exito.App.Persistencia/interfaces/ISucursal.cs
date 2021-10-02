using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface ISucursalRepository
    {
        public Sucursal Save(Sucursal Sucursal);
        public Sucursal Update(Sucursal Sucursal);
        public List<Sucursal> FindAll();
        public Sucursal FindOne(int id);
        public bool Delete(int id);

        
    }

}