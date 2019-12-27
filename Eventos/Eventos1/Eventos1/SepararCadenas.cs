using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{
    class SepararCadenas: ISeparar
    {
      
        List<string> NombreEvento = new List<string>();
        List<DateTime> Fechas = new List<DateTime>();
        public List<string> Separar(List<string> linea)
        {
            foreach (string cadena in linea)
            {
                string[] datos = cadena.Split(",");
                NombreEvento.Add(datos[0]);
            }
            return NombreEvento;
           
        }
    }
}
