using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{
    class Horas : IHoras
    {
        string cMensaje;
        public string CalcularFecha(string evento, TimeSpan tiempo)
        {
            if (tiempo.Hours < 24 && tiempo.Days == 0)
            {
                 cMensaje = evento + " Ha ocurrido hace " + tiempo.Hours + " Horas";

            }
            return cMensaje;
        }
    }
}
