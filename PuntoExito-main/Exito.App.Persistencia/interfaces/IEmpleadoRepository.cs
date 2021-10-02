using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface IEmpleadoRepository
    {
        public Empleado Save(Empleado empleado);
        public Empleado Update(Empleado empleado);
        public List<Empleado> FindAll();
        public Empleado FindOne(int id);
        public bool Delete(int id);
        
    }

}