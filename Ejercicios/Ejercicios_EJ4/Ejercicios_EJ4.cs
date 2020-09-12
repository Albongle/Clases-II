using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ4
{
    class Ejercicios_EJ4
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            int numero = 1;
            Console.WriteLine("Los numeros perfectos son:");
            do
            {
                for(int i=1; i<numero; i++)
                {
                    if((numero%i)==0)
                    {
                        acumulador += i;
                    }
                }
                if(acumulador==numero)
                {
                    Console.WriteLine(numero);
                    contador++;
                }

                numero++;
                acumulador = 0;
            } while (contador < 4);

            Console.ReadKey();
        }
    }
}
