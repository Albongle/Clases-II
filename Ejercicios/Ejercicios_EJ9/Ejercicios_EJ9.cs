using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ9
{
    class Ejercicios_EJ9
    {
        static void Main(string[] args)
        {
            int altura;
            Console.WriteLine("Ingrese la altura de la piramide:");
            int.TryParse(Console.ReadLine(), out altura);
            Console.WriteLine();
            for (int i=0; i<altura;i++)
            {               
                for(int j=0; j<(i*2); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
