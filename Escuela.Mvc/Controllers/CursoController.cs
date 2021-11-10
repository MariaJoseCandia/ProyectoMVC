using Microsoft.AspNetCore.Mvc;
using Escuela.Core;

namespace Escuela.Controllers
{
    public class CursoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
         => View(Repositorio.Curso); 

        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Curso curso)
        {
            Repositorio.AgregarCurso(curso);
            return View("Index", Repositorio.Curso);
        }

    }
}
