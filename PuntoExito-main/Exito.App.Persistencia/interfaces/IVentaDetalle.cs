using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface IVentaDetalle

    {
        public VentaDetalle Save(VentaDetalle ventadetalle);
        public VentaDetalle Update(VentaDetalle ventadetalle);
        public List<VentaDetalle> FindAll();
        public VentaDetalle FindOne(int id);
        public bool Delete(int id);
        
    }

}