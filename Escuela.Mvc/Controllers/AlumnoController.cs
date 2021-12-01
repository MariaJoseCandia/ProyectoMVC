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
        public IActionResult FormAlta()
        {
            var vmAlumno = new VMAlumno(Repositorio.Cursos);
            return View(vmAlumno);
        }

        [HttpPost]
        public IActionResult FormAlta(VMAlumno vMAlumno)
        {
            var curso = Repositorio.GetCurso(vMAlumno.IdCursoSeleccionado.Value);
            vMAlumno.Alumno.curso = curso;
            Repositorio.AgregarAlumno(vMAlumno.Alumno);
            return RedirectToAction("Index");
        }

    }
}
