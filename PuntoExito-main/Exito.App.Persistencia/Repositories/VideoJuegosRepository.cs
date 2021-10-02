using System.Collections.Generic;
using System.Linq;
using Exito.App.Dominio;

namespace Exito.App.Persistencia
{
    public class VideoJuegoRepository : IVideoJuego
    {

        private readonly AppContext _context;


        public VideoJuegoRepository(AppContext appContext){
            this._context = appContext;
        }
        public VideoJuego Save(VideoJuego videojuego){
            var vidj = _context.VideoJuegos.Add(videojuego);
            _context.SaveChanges();
            return vidj.Entity;
        }
        public VideoJuego Update(VideoJuego videojuego){
            //duda al llamar el id por que esta en la tabla Producto(andres)
            var videojuegoEncontrado = _context.VideoJuegos.FirstOrDefault(p=>p.Id == videojuego.Id);
            if(videojuegoEncontrado != null){
                videojuegoEncontrado.Nombre = videojuego.Nombre;
                videojuegoEncontrado.Version = videojuego.Version;
                videojuegoEncontrado.Fabricante = videojuego.Fabricante;
                videojuegoEncontrado.precioCompra = videojuego.precioCompra;
                videojuegoEncontrado.precioVenta = videojuego.precioVenta;
                // empleadoEncontrado.Sucursal = empleado.Sucursal;
                // empleadoEncontrado.Rol = empleado.Rol;
                this._context.SaveChanges();
            }
            return videojuegoEncontrado;
 
        }
        public List<VideoJuego> FindAll(){
            return this._context.VideoJuegos.ToList();
        }
        public VideoJuego FindOne(int id){
            var videojuegoEncontrado = _context.VideoJuegos.FirstOrDefault(p=>p.Id == id);
            return videojuegoEncontrado;
        }
        public bool Delete(int id){
            var videojuegoEncontrado = _context.VideoJuegos.FirstOrDefault(p=>p.Id == id);
            if(videojuegoEncontrado != null){
                this._context.VideoJuegos.Remove(videojuegoEncontrado);
                this._context.SaveChanges();
                return true;
            }
            return false;

        }
    }

}