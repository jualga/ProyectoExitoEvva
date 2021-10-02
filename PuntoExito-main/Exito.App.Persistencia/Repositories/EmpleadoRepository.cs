using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class EmpleadoRepository : IEmpleadoRepository
    {

        private readonly AppContext _context;


        public EmpleadoRepository(AppContext appContext){
            this._context = appContext;
        }
        public Empleado Save(Empleado empleado){
            var emp = _context.Empleados.Add(empleado);
            _context.SaveChanges();
            return emp.Entity;
        }
        public Empleado Update(Empleado empleado){
            var empleadoEncontrado = _context.Empleados.FirstOrDefault(p=>p.EmpleadoId == empleado.EmpleadoId);
            if(empleadoEncontrado != null){
                empleadoEncontrado.Nombre = empleado.Nombre;
                empleadoEncontrado.Apellido = empleado.Apellido;
                empleadoEncontrado.Usuario = empleado.Usuario;
                empleadoEncontrado.Clave = empleado.Clave;
                // empleadoEncontrado.Sucursal = empleado.Sucursal;
                // empleadoEncontrado.Rol = empleado.Rol;
                this._context.SaveChanges();
            }
            return empleadoEncontrado;

        }
        public List<Empleado> FindAll(){
            return this._context.Empleados.ToList();
        }
        public Empleado FindOne(int id){
            var empleadoEncontrado = _context.Empleados.FirstOrDefault(p=>p.EmpleadoId == id);
            return empleadoEncontrado;
        }
        public bool Delete(int id){
            var empleadoEncontrado = _context.Empleados.FirstOrDefault(p=>p.EmpleadoId == id);
            if(empleadoEncontrado != null){
                this._context.Empleados.Remove(empleadoEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}