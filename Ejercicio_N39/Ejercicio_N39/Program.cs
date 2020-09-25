using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº39 Guía 2017";
            SobreSobreescrito sobreEscrito= new SobreSobreescrito();
            Console.WriteLine(sobreEscrito.MiMetodo());
            Console.ReadKey();
        }
    }
}
