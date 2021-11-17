using Microsoft.AspNetCore.Mvc;
using Escuela.Core;

namespace Escuela.Controllers
{
    public class AlumnoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
         => View(Repositorio.Alumno); 

        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Alumno alumno)
        {
            Repositorio.AgregarAlumno(alumno);
            return View("Index", Repositorio.Alumno);
        }

    }
}
