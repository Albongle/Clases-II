using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ2
{
    class Ejercicio_EJ2
    {
        static void Main(string[] args)
        {

            int ingreso;
            bool flag;
            do
            {
                Console.Title = "Ejercicio Numero 2";
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso < 0)
                {
                    flag = true;
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                else
                {
                    flag = false;
                }

            } while (flag);
            Console.WriteLine("el cuadrado del numero ingresado es {0}", Math.Pow(ingreso, 2));
            Console.ReadKey();
        }
    }
}
