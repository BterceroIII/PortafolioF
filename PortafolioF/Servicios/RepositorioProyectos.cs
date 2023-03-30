using PortafolioF.Models;

namespace PortafolioF.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos:IRepositorioProyectos
    {

        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {

            new ProyectoDTO
            {
                Titulo = "Nucleus",
                Descrípcion = "Pagina que sobre la app de Nucleus",
                Link = "https://nucleustercero.netlify.app",
                ImagenURL = "/img/Nucleus.png "
            },
            new ProyectoDTO
            {
                Titulo = "TechPRO",
                Descrípcion = "Pagina que sobre la app de TechPRO",
                Link = "https://btpro.netlify.app",
                ImagenURL = "/img/TechPRO.png "
            },
            new ProyectoDTO
            {
                Titulo = "Arquitectura",
                Descrípcion = "Modelo de pagina en la empresa de Arquitectura",
                Link = "https://bterceroarquitec.netlify.app",
                ImagenURL = "/img/Arquitectura.png "
            },
            new ProyectoDTO
            {
                Titulo = "Tercero Comercial",
                Descrípcion = "Modelo de pagina en la empresa de Tercero Comercial",
                Link = "https://01ecomerce.netlify.app",
                ImagenURL = "/img/tercero.png "
            },
            new ProyectoDTO
            {
                Titulo = "App Comida",
                Descrípcion = "Pagina  usando SASS y gulp sobre delivery",
                Link = "https://sassdelivery.netlify.app",
                ImagenURL = "/img/delivery.png "
            },
            new ProyectoDTO
            {
                Titulo = "Podcast FM",
                Descrípcion = "Pagina  usando SASS y gulp sobre una plataforma de podcast",
                Link = "https://podcasttercero.netlify.app",
                ImagenURL = "/img/Podcast.png "
            },

            };
        }
    }
}
