using System;

namespace Escuela.Core
{
    public class Falta
    {
        public int Id { get; set; }
        public Alumno Alumno { get; set; }
        public float ValorFalta { get; set; }
        public DateTime Fecha { get; set; }

        public Falta(float valorFalta, DateTime fecha, Alumno alumno)
        {
            ValorFalta = valorFalta;
            Fecha = DateTime.Now;
        }
    }
}