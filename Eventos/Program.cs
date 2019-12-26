using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Eventos e = new Eventos();

            e.LeerArchivo();
            e.Separar();
            e.imprimir();
            e.convertirFechas();
            e.compararFechas();
        }
    }
}
