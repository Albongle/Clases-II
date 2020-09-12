using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicios_EJ11
{
    class Ejercicios_EJ11
    {
        static void Main(string[] args)
        {
            int ingreso;
            int max=int.MinValue;
            int min = int.MaxValue; 
            int i = 0;
            int acum = 0;
            float promedio;
            bool resultado;
            do
            {                
                Console.WriteLine("Ingrese el numero {0}:", i);
                int.TryParse(Console.ReadLine(), out ingreso);
                if ((resultado = ValidarNumero.ValidarInt(ingreso, -100, 100)))
                {
                    if(i==0 || ingreso>max)
                    {
                        max = ingreso;
                    }
                    if (i == 0 || ingreso < min)
                    {
                        min = ingreso;
                    }
                    acum += ingreso;
                    i++;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número >= a -100 y <= que 100");
                }

            }while (i < 10 || resultado == false);

            promedio = (float)acum / i;
            Console.WriteLine("El maximo es {0}, el minimo es {1} y el promedio es {2}", max, min, promedio);
            Console.ReadKey();

        }
    }
}
