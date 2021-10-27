using System;
using System.Collections.Generic;

namespace Escuela.Core
{
    public class Falta
    {
        public float ValorFalta { get; set; }
        public DateTime Fecha { get; set; }

        public Falta(float valorFalta, DateTime fecha)
        {
            ValorFalta = valorFalta;
            Fecha = DateTime.Now;
        }
    }
}