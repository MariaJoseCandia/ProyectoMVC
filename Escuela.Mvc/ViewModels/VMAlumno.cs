using Escuela.Core;
using System.Collections.Generic;

namespace Escuela.Mvc.ViewModels
{
    public class VMAlumno
    {
        public IEnumerable<Curso> Cursos { get; set; }
        public Alumno Alumno { get; set; }
        public int? IdCursoSeleccionado { get; set; }
        public VMAlumno() => Alumno = new Alumno();
        public VMAlumno(IEnumerable<Curso> cursos) : this()
            => Cursos = cursos;
        public VMAlumno(Alumno alumno)
        {
            Alumno = alumno;            
        }
    }
}