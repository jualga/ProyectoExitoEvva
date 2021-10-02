using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class RolRepository : IRolRepository
    {

        private readonly AppContext _context;


        public RolRepository(AppContext appContext){
            this._context = appContext;
        }
        public Rol Save(Rol rol){
            var NewRol = _context.Roles.Add(rol);
            _context.SaveChanges();
            return NewRol.Entity;
        }
        public Rol Update(Rol rol){
            var RolEncontrado = _context.Roles.FirstOrDefault(r=>r.RolId == rol.RolId);
            if(RolEncontrado != null){
                RolEncontrado.Nombre = rol.Nombre;
                this._context.SaveChanges();
            }
            return RolEncontrado;

        }
        public List<Rol> FindAll(){
            return this._context.Roles.ToList();
        }
        public Rol FindOne(int id){
            var RolEncontrado = _context.Roles.FirstOrDefault(r=>r.RolId == id);
            return RolEncontrado;
        }
        public bool Delete(int id){
            var RolEncontrado = _context.Roles.FirstOrDefault(r=>r.RolId == id);
            if(RolEncontrado != null){
                this._context.Roles.Remove(RolEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}