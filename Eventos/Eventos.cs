using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos
{
    class Eventos
    {
       
        string line;
        List<string> lineas = new List<string>();
        List<string> Fecha = new List<string>();
        List<string> NombreEvento = new List<string>();
        List<DateTime> Fechas = new List<DateTime>();

        

        public void LeerArchivo()
        {
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"c:\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                lineas.Add(line);
            }

            file.Close();
        }

        public void Separar()
        {
            foreach(string cadena in lineas)
            {
                string[] datos = cadena.Split(",");
                NombreEvento.Add(datos[0]);
                Fecha.Add(datos[1]);
                
            }
        }

        public void convertirFechas()
        {
            foreach(string f in Fecha)
            {
                DateTime fechas = DateTime.Parse(f);
                Fechas.Add(fechas);
            }
        }

        public void compararFechas()
        {
            foreach ( DateTime fech in Fechas)
            {
                TimeSpan d = DateTime.Now.Subtract(fech);
                Console.WriteLine(d);
            }
        }


        

        public void imprimir()
        {
            foreach(string evento in Fecha){
                Console.WriteLine(evento);
            }

            foreach (string evento in NombreEvento)
            {
                Console.WriteLine(evento);
            }
        }

    }
}
