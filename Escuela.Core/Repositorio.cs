using System.Collections.Generic;
using System.Linq;

namespace Escuela.Core
{
    public class Repositorio
    {
        static int idFalta = 1;
        static int idCurso = 1;
        static int idAlumno = 1;
        public List<Curso> Cursos = new List<Curso>(); 
        public List<Alumno> alumnos = new List<Alumno>();
        public List<Falta> faltas = new List<Falta>();
        public static void AgregarCurso(Curso cursos)
        {
            cursos.Id = idCurso++;
        }

        public static void AgregarAlumno(Alumno alumnos)
        {
            alumnos.Id = idAlumno++;
        }

        public static void AgregarFalta(Falta faltas, float valorFalta)
        {
            faltas.Id = idFalta++;
        }
    }
}