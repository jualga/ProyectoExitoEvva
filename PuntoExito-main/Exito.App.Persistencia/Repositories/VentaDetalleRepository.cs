using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class VentaDetalleRepository : IVentaDetalle
    {

        private readonly AppContext _context;


        public VentaDetalleRepository(AppContext appContext){
            this._context = appContext;
        }
        public VentaDetalle Save(VentaDetalle ventadetalle){
            var vendet = _context.VentaDetalles.Add(ventadetalle);
            _context.SaveChanges();
            return vendet.Entity;
        }
        public VentaDetalle Update(VentaDetalle ventadetalle){
            //duda con el id (andres)
            var ventadetalleEncontrado = _context.VentaDetalles.FirstOrDefault(p=>p.Id == ventadetalle.Id);
            if(ventadetalleEncontrado != null){
                ventadetalleEncontrado.VentaId = ventadetalle.VentaId;
                ventadetalleEncontrado.Venta = ventadetalle.Venta;
                ventadetalleEncontrado.ConsolaId = ventadetalle.ConsolaId;
                ventadetalleEncontrado.Consola = ventadetalle.Consola;
                ventadetalleEncontrado.Cantidad = ventadetalle.Cantidad;
                // empleadoEncontrado.Sucursal = empleado.Sucursal;
                // empleadoEncontrado.Rol = empleado.Rol;
                this._context.SaveChanges();
            }
            return ventadetalleEncontrado;

        }
        public List<VentaDetalle> FindAll(){
            return this._context.VentaDetalles.ToList();
        }
        public VentaDetalle FindOne(int id){
            var ventadetalleEncontrado = _context.VentaDetalles.FirstOrDefault(p=>p.Id == id);
            return ventadetalleEncontrado;
        }
        public bool Delete(int id){
            var ventadetalleEncontrado = _context.VentaDetalles.FirstOrDefault(p=>p.Id == id);
            if(ventadetalleEncontrado != null){
                this._context.VentaDetalles.Remove(ventadetalleEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}