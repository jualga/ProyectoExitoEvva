using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface Icontrol
    {
        public Control Save(Control control);
        public Control Update(Control control);
        public List<Control> FindAll();
        public Control FindOne(int id);
        public bool Delete(int id);
        
    }

}