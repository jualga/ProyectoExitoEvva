using System.Collections.Generic;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public interface IVideoJuego

    { 
        public VideoJuego Save(VideoJuego videojuego);
        public VideoJuego Update(VideoJuego videojuego);
        public List<VideoJuego> FindAll();
        public VideoJuego FindOne(int id);
        public bool Delete(int id);
        
    }

}