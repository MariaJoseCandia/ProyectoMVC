using System.Collections.Generic;

namespace Escuela.Core
{
    public class Curso
    {
        public int Id { get; set; }
        public byte Anio { get; set; }
        public byte Division { get; set; }
        public string Turno { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Curso() => Alumnos = new List<Alumno>();
    }
}