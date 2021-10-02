using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class SucursalRepository : ISucursalRepository
    {

        private readonly AppContext _context;


        public SucursalRepository(AppContext appContext){
            this._context = appContext;
        }
        public Sucursal Save(Sucursal Sucursal){
            var NewSucursal = _context.Sucursales.Add(Sucursal);
            _context.SaveChanges();
            return NewSucursal.Entity;
        }
        public Sucursal Update(Sucursal Sucursal){
            var SucursalEncontrado = _context.Sucursales.FirstOrDefault(s=>s.SucursalId == Sucursal.SucursalId);
            if(SucursalEncontrado != null){
                SucursalEncontrado.Nombre = Sucursal.Nombre;
                this._context.SaveChanges();
            }
            return SucursalEncontrado;

        }
        public List<Sucursal> FindAll(){
            return this._context.Sucursales.ToList();
        }
        public Sucursal FindOne(int id){
            var SucursalEncontrado = _context.Sucursales.FirstOrDefault(s=>s.SucursalId == id);
            return SucursalEncontrado;
        }
        public bool Delete(int id){
            var SucursalEncontrado = _context.Sucursales.FirstOrDefault(s=>s.SucursalId == id);
            if(SucursalEncontrado != null){
                this._context.Sucursales.Remove(SucursalEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}