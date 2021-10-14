using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class VentaRepository : IVenta
    {

        private readonly AppContext _context;


        public VentaRepository(AppContext appContext){
            this._context = appContext;
        }
        public Venta Save(Venta venta){
            var vent = _context.Ventas.Add(venta);
            _context.SaveChanges();
            return vent.Entity;
        }
        public Venta Update(Venta venta){
            var ventaEncontrado = _context.Ventas.FirstOrDefault(p=>p.VentaId == venta.VentaId);
            if(ventaEncontrado != null){
                ventaEncontrado.Fecha = venta.Fecha;
                ventaEncontrado.Total = venta.Total;
                ventaEncontrado.Finalizada = venta.Finalizada;
                ventaEncontrado.EmpleadoId = venta.EmpleadoId;
                ventaEncontrado.Empleado = venta.Empleado;
                // empleadoEncontrado.Sucursal = empleado.Sucursal;
                // empleadoEncontrado.Rol = empleado.Rol;
                this._context.SaveChanges();
            }
            return ventaEncontrado;

        }
        public List<Venta> FindAll(){
            return this._context.Ventas.ToList();
        }
        public Venta FindOne(int id){
            var ventaEncontrado = _context.Ventas.FirstOrDefault(p=>p.VentaId == id);
            return ventaEncontrado;
        }
        public bool Delete(int id){
            var ventaEncontrado = _context.Ventas.FirstOrDefault(p=>p.VentaId == id);
            if(ventaEncontrado != null){
                this._context.Ventas.Remove(ventaEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}