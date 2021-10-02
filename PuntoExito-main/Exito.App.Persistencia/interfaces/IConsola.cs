using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface IConsola

    {
        public Consola Save(Consola consola);
        public Consola Update(Consola consola);
        public List<Consola> FindAll();
        public Consola FindOne(int id);
        public bool Delete(int id);
        
    }

}