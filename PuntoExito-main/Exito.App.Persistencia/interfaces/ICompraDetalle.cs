using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface ICompraDetalle

    {
        public CompraDetalle Save(CompraDetalle compradetalle);
        public CompraDetalle Update(CompraDetalle compradetalle);
        public List<CompraDetalle> FindAll();
        public CompraDetalle FindOne(int id);
        public bool Delete(int id);
        
    }

}