using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ6
{
    class Ejercicios_EJ6
    {
        static void Main(string[] args)
        {
            int anioDesde;
            int anioHasta;
       
            Console.WriteLine("Ingrese el año de inicio:");
            int.TryParse(Console.ReadLine(), out anioDesde);
            Console.WriteLine("Ingrese el año de fin:");
            int.TryParse(Console.ReadLine(), out anioHasta);
            Console.WriteLine("Los años bisiestos del rango seleccionado son:");
            for (int i= anioDesde; i<=anioHasta; i++)
            {             
                if((((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0)))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
