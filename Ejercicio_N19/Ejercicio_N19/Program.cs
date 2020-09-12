using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador();
                      
            Console.WriteLine("El resultado de la suma es {0}", sumadorUno.Sumar("20", "30"));
            Console.WriteLine("El resultado de la suma es {0}", sumadorDos.Sumar("5", "8"));
            Console.WriteLine("La conversion es {0}", (long)sumadorUno);
            Console.WriteLine("La cantidad de sumas entre los 2 es {0}", sumadorUno+sumadorDos);
            Console.WriteLine("Ambos tienen la misma cantidad de sumas? {0}", (sumadorUno | sumadorDos));

            Console.ReadKey();
        }
    }
}
