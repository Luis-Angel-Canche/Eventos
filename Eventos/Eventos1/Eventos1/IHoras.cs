using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{
    interface IHoras
    {
        public string CalcularFecha(string Evento, TimeSpan tiempo);
    }
}
