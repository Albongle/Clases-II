using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ1
{
    class Ejercicios_EJ1
    {
        static void Main(string[] args)
        {
            int ingreso;
            int max = int.MinValue;
            float promedio;
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero {0}: ", i);
                int.TryParse(Console.ReadLine(), out ingreso);
                if (i == 0 || ingreso > max)
                {
                    max = ingreso;
                    suma += ingreso;
                }
            }
            promedio = (float)suma / 5;
            Console.WriteLine("El promedio es {0} y el maximo ingreso fue {1}", promedio, max);
            Console.ReadKey();

        }
    }
}
