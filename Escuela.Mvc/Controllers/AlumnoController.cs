using Microsoft.AspNetCore.Mvc;
using Escuela.Core;
using Escuela.Mvc.ViewModels;

namespace Escuela.Controllers
{
    public class AlumnoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
         => View(Repositorio.Alumno); 

        [HttpGet]
        public IActionResult FormAlta(int? idCurso)
        {
            var vmAlumno = new VMAlumno(Repositorio.Cursos)
            {
                IdCursoSeleccionado = idCurso
            };
            return View(vmAlumno);
        }

        [HttpPost]
        public IActionResult FormAlta(Alumno alumno)
        {
            Repositorio.AgregarAlumno(alumno);
            return View("Index", Repositorio.Alumno);
        }

    }
}
