using System.Collections.Generic;
using System.Linq;

namespace Escuela.Core
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public Curso curso { get; set; }
        public List<Falta> Faltas { get; set; }
        public Alumno() => Faltas = new List<Falta>();
        public float SumaFaltas => Faltas.Sum(f => f.ValorFalta);

    }
}
