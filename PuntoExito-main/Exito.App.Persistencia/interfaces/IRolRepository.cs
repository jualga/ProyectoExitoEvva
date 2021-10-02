using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface IRolRepository
    {
        public Rol Save(Rol Rol);
        public Rol Update(Rol Rol);
        public List<Rol> FindAll();
        public Rol FindOne(int id);
        public bool Delete(int id);

        
    }

}