using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class ControlRepository : Icontrol
    {

        private readonly AppContext _context;


        public ControlRepository(AppContext appContext){
            this._context = appContext;
        }
        public Control Save(Control control){
            var contr = _context.Controles.Add(control);
            _context.SaveChanges();
            return contr.Entity;
        }
        public Control Update(Control control){
            //duda al llamar el id por que esta en la tabla Producto(andres)
            var controlEncontrado = _context.Controles.FirstOrDefault(p=>p.Id == control.Id);
            if(controlEncontrado != null){
                controlEncontrado.Nombre = control.Nombre;
                controlEncontrado.Version = control.Version;
                controlEncontrado.Fabricante = control.Fabricante;
                controlEncontrado.precioCompra = control.precioCompra;
                controlEncontrado.precioVenta = control.precioVenta;
                controlEncontrado.Cantidad = control.Cantidad;
                this._context.SaveChanges();
            }
            return controlEncontrado;

        }
        public List<Control> FindAll(){
            return this._context.Controles.ToList();
        }
        public Control FindOne(int id){
            var controlEncontrado = _context.Controles.FirstOrDefault(p=>p.Id == id);
            return controlEncontrado;
        }
        public bool Delete(int id){
            var controlEncontrado = _context.Controles.FirstOrDefault(p=>p.Id == id);
            if(controlEncontrado != null){
                this._context.Controles.Remove(controlEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}