using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class ConsolaRepository : IConsola
    {

        private readonly AppContext _context;


        public ConsolaRepository(AppContext appContext){
            this._context = appContext;
        }
        public Consola Save(Consola consola){
            var cons = _context.Consolas.Add(consola);
            _context.SaveChanges();
            return cons.Entity;
        }
        public Consola Update(Consola consola){
            //duda id por que consola hereda de producto (andres)
            var ConsolaEncontrado = _context.Consolas.FirstOrDefault(p=>p.Id == consola.Id);
            if(ConsolaEncontrado != null){
                ConsolaEncontrado.Almacenamiento= consola.Almacenamiento;
                ConsolaEncontrado.VelocidadRam = consola.VelocidadRam;
                ConsolaEncontrado.VelocidadProcesamiento = consola.VelocidadProcesamiento;
                //duda con el TypoDisco por que es enum (andres)
                ConsolaEncontrado.TypoDisco = consola.TypoDisco;
                // empleadoEncontrado.Sucursal = empleado.Sucursal;
                // empleadoEncontrado.Rol = empleado.Rol;
                this._context.SaveChanges();
            }
            return ConsolaEncontrado;

        }
        public List<Consola> FindAll(){
            return this._context.Consolas.ToList();
        }
        public Consola FindOne(int id){
            var ConsolaEncontrado = _context.Consolas.FirstOrDefault(p=>p.Id == id);
            return ConsolaEncontrado;
        }
        public bool Delete(int id){
            var ConsolaEncontrado = _context.Consolas.FirstOrDefault(p=>p.Id == id);
            if(ConsolaEncontrado != null){
                this._context.Consolas.Remove(ConsolaEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}