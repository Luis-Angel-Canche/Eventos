using System;
using System.Collections.Generic;

namespace Eventos1
{
    class Program
    {
        static void Main(string[] args)
        {
            LeerArchivo leerArchivo = new LeerArchivo();
            SepararCadenas separarCadenas = new SepararCadenas();
            ObtenerFecha obtener = new ObtenerFecha();
            Horas horas = new Horas();

            List<string> Linea = leerArchivo.leer(@"c:\test.txt");
            List<string> Evento = separarCadenas.Separar(Linea);
            List<DateTime> Fecha = obtener.ObtenerDate(Linea);

            

            for (int i = 0; i < Linea.Count; i++)
            {
                Evento evento = new Evento(Evento[i], Fecha[i]);
                TimeSpan Tiempo = evento.ComparaFecha(evento.Fecha);
                if(Convert.ToInt64(Tiempo.Ticks) > 0)
                {
                    string cMensaje = horas.CalcularFecha(evento.NombreEvento, Tiempo);
                    Console.WriteLine(cMensaje);
                }
                
            }
        }
    }
}

