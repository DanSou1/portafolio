using Portafolio.Models;
namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> obtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> obtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Titulo =  "Amazon",
                    Descripcion = "E-Commerce realizado en ASP .NET Core",
                    Link = "Google.com",
                    ImagenURL = "FF"
                },
                 new ProyectoDTO
                {
                    Titulo =  "Amazon",
                    Descripcion = "E-Commerce realizado en ASP .NET Core",
                    Link = "Google.com",
                    ImagenURL = "FF"
                },
                  new ProyectoDTO
                {
                    Titulo =  "Amazon",
                    Descripcion = "E-Commerce realizado en ASP .NET Core",
                    Link = "Google.com",
                    ImagenURL = "FF"
                },
                   new ProyectoDTO
                {
                    Titulo =  "Amazon",
                    Descripcion = "E-Commerce realizado en ASP .NET Core",
                    Link = "Google.com",
                    ImagenURL = " DF"
                },
            };
        }
    }
}
