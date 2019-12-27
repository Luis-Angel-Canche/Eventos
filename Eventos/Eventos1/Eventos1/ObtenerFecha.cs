using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{
    class ObtenerFecha: IObtenerFecha
    {
        List<DateTime> Fecha = new List<DateTime>();

        public List<DateTime> ObtenerDate(List<string> linea)
        {
            foreach (string cadena in linea)
            {
                string[] datos = cadena.Split(",");
                Fecha.Add(DateTime.Parse(datos[1]));
            }
            return Fecha;
        } 

    }
}
