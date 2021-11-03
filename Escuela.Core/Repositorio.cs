using System.Collections.Generic;
using System.Linq;

namespace Escuela.Core
{
    public class Repositorio
    {
        static int idFalta = 1;
        static int idCurso = 1;
        static int idAlumno = 1;
        public static List<Curso> Curso { get; set; } 
        public static List<Alumno> Alumno { get; set; }
        public static List<Falta> Falta { get; set;}
        public static void AgregarCurso(Curso curso)
        {
            curso.Id = idCurso++;
            Curso.Add(curso);
        }

        public static void AgregarAlumno(Alumno alumno)
        {
            alumno.Id = idAlumno++;
            Alumno.Add(alumno);
        }

        public static void AgregarFalta(Falta falta)
        {
            falta.Id = idFalta++;
            Falta.Add(falta);
        }
        
        public static Curso GetCurso(int id)
            => Curso.Find(c => c.Id == id); 

        public static Alumno GetAlumno(int id )
            => Alumno.Find(a => a.Id == id); 
        
        public static Falta GetFaltaDeAlumno(int id)
            => Falta.Find(f => f.Alumno.Id == id); 
    }
}