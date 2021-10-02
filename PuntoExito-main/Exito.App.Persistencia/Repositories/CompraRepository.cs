using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class CompraRepository : ICompra
    {

        private readonly AppContext _context;


        public CompraRepository(AppContext appContext){
            this._context = appContext;
        }
        public Compra Save(Compra compra){
            var comp = _context.Compras.Add(compra);
            _context.SaveChanges();
            return comp.Entity;
        }
        public Compra Update(Compra compra){
            var compraEncontrado = _context.Compras.FirstOrDefault(p=>p.CompraId == compra.CompraId);
            if(compraEncontrado != null){
                // compraEncontrado.Compra = compra.Compra;
                // compraEncontrado.ConsolaId = compra.ConsolaId;
                // compraEncontrado.Consola = compra.Consola;
                // compraEncontrado.Cantidad = compra.Cantidad;
                // empleadoEncontrado.Rol = empleado.Rol;
                this._context.SaveChanges();
            }
            return compraEncontrado;

        }
        public List<Compra> FindAll(){
            return this._context.Compras.ToList();
        }
        public Compra FindOne(int id){
            var compraEncontrado = _context.Compras.FirstOrDefault(p=>p.CompraId == id);
            return compraEncontrado;
        }
        public bool Delete(int id){
            var compraEncontrado = _context.Compras.FirstOrDefault(p=>p.CompraId == id);
            if(compraEncontrado != null){
                this._context.Compras.Remove(compraEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}