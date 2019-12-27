using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{
    class Evento: ICompararFecha
    {
        public string NombreEvento { get; set; }

        public DateTime Fecha { get; set; }

        public Evento (string NombreEvento, DateTime Fecha)
        {
            this.NombreEvento = NombreEvento;
            this.Fecha = Fecha;
        }

        public TimeSpan ComparaFecha(DateTime Fecha)
        {
            TimeSpan FechaE = DateTime.Now.Subtract(Fecha);
            return FechaE;
        }
    }
}
