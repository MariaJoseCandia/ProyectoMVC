using System.Collections.Generic;

namespace Escuela.Core
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public List<Falta> CantFaltas { get; set; }
        public Alumno() => CantFaltas = new List<Falta>();
    }
}
