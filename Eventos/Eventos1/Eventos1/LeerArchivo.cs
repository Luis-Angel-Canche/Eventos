using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{
    class LeerArchivo: ILectorDeArchivo
    {
        string linea;
        List<string> datos = new List<string>();
       public List<string> leer(string Archivo)
        {
            System.IO.StreamReader file =
            new System.IO.StreamReader(Archivo);
            while ((linea = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                datos.Add(linea);
            }

            file.Close();
            return datos;
        }
    }


}
