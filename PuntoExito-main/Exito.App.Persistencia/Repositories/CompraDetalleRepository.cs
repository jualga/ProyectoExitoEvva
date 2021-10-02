using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class CompraDetalleRepository : ICompraDetalle
    {

        private readonly AppContext _context;


        public CompraDetalleRepository(AppContext appContext){
            this._context = appContext;
        }
        public CompraDetalle Save(CompraDetalle compradetalle){
            var comdet = _context.CompraDetalles.Add(compradetalle);
            _context.SaveChanges();
            return comdet.Entity;
        }
        public CompraDetalle Update(CompraDetalle compradetalle){
            var compradetalleEncontrado = _context.CompraDetalles.FirstOrDefault(p=>p.CompraId == compradetalle.CompraId);
            if(compradetalleEncontrado != null){
                // compradetalleEncontrado.CompraId = compradetalle.CompraId;
                // compradetalleEncontrado.Compra = compradetalle.Compra;
                // compradetalleEncontrado.ConsolaId = compradetalle.ConsolaId;
                // compradetalleEncontrado.Consola = compradetalle.Consola;
                // compradetalleEncontrado.Cantidad = compradetalle.Cantidad;
                // empleadoEncontrado.Rol = empleado.Rol;
                this._context.SaveChanges();
            }
            return compradetalleEncontrado;

        }
        public List<CompraDetalle> FindAll(){
            return this._context.CompraDetalles.ToList();
        }
        public CompraDetalle FindOne(int id){
            var compradetalleEncontrado = _context.CompraDetalles.FirstOrDefault(p=>p.CompraId == id);
            return compradetalleEncontrado;
        }
        public bool Delete(int id){
            var compradetalleEncontrado = _context.CompraDetalles.FirstOrDefault(p=>p.CompraId == id);
            if(compradetalleEncontrado != null){
                this._context.CompraDetalles.Remove(compradetalleEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}