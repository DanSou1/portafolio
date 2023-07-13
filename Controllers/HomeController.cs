using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(
            IRepositorioProyectos repositorioProyectos)
        {
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            var repositiorioProyectos = new RepositorioProyectos();
            var proyectos = repositiorioProyectos.obtenerProyectos().Take(3).ToList();


            var modelo = new HomeIndexViewModel() {
                Proyectos = proyectos
            };
            return View(modelo);
        }

        private object obtenerProyectos()
        {
            throw new NotImplementedException();
        }

        public IActionResult Proyectos()
        {
            var Proyectos = repositorioProyectos.obtenerProyectos();
            return View(Proyectos);
        } 
        public IActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel) 
        {
            return RedirectToAction("Gracias");
        }
        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}