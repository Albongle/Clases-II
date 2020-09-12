using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicios_EJ15
{
    class Ejercicios_EJ15
    {
        static void Main(string[] args)
        {
            char operadorElegido;
            int operadorA;
            int operadorB;
            float resultado;
            do
            {
                Console.Clear();
                operadorElegido = EleccionOperador();
                if(operadorElegido!='0')
                {
                    Console.WriteLine("Ingrese el primer numero:");
                    int.TryParse(Console.ReadLine(), out operadorA);
                    Console.WriteLine("Ingrese el Segundo numero:");
                    int.TryParse(Console.ReadLine(), out operadorB);
                    resultado = Calculadora.Calcular(operadorA, operadorB, operadorElegido);
                    Console.WriteLine("El resultado de la operacion {0}, es {1}", operadorElegido, resultado);
                }
                Console.ReadKey();
            } while (operadorElegido != '0');
        }
        private static char EleccionOperador()
        {
            char returnAux=char.MinValue;
            Console.WriteLine("Elija el calculo a realizar:\n(+) Suma\n(-) Resta\n(*) Multiplicacion\n(/) Division\n(0) Salir");
            char.TryParse(Console.ReadLine(), out returnAux);
            return returnAux;
        }
    }
}
