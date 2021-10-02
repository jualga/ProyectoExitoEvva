using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface ICompra

    {
        public Compra Save(Compra compra);
        public Compra Update(Compra compra);
        public List<Compra> FindAll();
        public Compra FindOne(int id);
        public bool Delete(int id);
        
    }

}