using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicios_EJ14
{
    class Ejercicios_EJ14
    {
        static void Main(string[] args)
        {
            int opcion;
            double valoBase;
            do
            {
                Console.Clear();
                opcion= Menu();
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese el valor base del cuadrado:");
                            double.TryParse(Console.ReadLine(), out valoBase);
                            Console.WriteLine("El area del cuadrado es {0}", CalculoDeArea.CalculaCuadrado(valoBase));
                            break;
                        }
                    case 2:
                        {
                            double valorAltura;
                            Console.WriteLine("Ingrese la base del triangulo:");
                            double.TryParse(Console.ReadLine(), out valoBase);
                            Console.WriteLine("Ingrese la altura del triangulo:");
                            double.TryParse(Console.ReadLine(), out valorAltura);
                            Console.WriteLine("El area del triangulo es {0}", CalculoDeArea.CalcularTriangulo(valoBase, valorAltura));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ingrese el radio del circulo:");
                            double.TryParse(Console.ReadLine(), out valoBase);
                            Console.WriteLine("El area del circulo es {0}", CalculoDeArea.CalcularCirculo(valoBase));
                            break;
                        }  
                }
                Console.ReadKey();
            } while (opcion != 4);

            

        }

        private static int Menu()
        {
            int opcion = -1;
            Console.WriteLine("Elija una opcion:\n1-Calcular el area de una cuadrado\n2-Calcular el area de un trinangulo\n3-Calcular el area de un circulo\n4-Salir");
            int.TryParse(Console.ReadLine(), out opcion);
            return opcion;
        }
    }
}
