using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random azar = new Random();
            for (int i = 0; i < 20; i++)
            {
                numeros.Add(azar.Next(-100, 100));
            }
            Console.WriteLine("a.   Mostrar el vector tal como fue ingresado:");
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine("Numero[{0}]: {1}", i, numeros[i]);
            }
            numeros.Sort(FuncionCriterio); //ordeno la lista con funcion criterio
            Console.WriteLine("\n\nb.	Luego mostrar los positivos ordenados en forma decreciente");
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine("Numero[{0}]: {1}", i, numeros[i]);
                }
            }
            Console.WriteLine("\n\nc.	Por último, mostrar los negativos ordenados en forma creciente"); // recorro la lista de forma inversa a como esta ordenado para imprimir
            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine("Numero[{0}]: {1}", i, numeros[i]);
                }
            }
            Console.ReadKey();
        }
        private static int FuncionCriterio(int numeroUno, int numeroDos)
        {
            int returnAux = 0;
            if (numeroUno > numeroDos)
            {
                returnAux = -1;
            }
            else if (numeroUno < numeroDos)
            {
                returnAux = 1;
            }
            return returnAux;
        }
    }
}
