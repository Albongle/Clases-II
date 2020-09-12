using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversor;

namespace Ejercicio_N22
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblAux;
            NumeroDecimal objDecimal;
            NumeroBinario objBinario;
            Console.WriteLine("Ingrese un numero en decimal:");
            double.TryParse(Console.ReadLine(), out dblAux);
            objDecimal = dblAux;
            Console.WriteLine("Ingrese un numero en Binario:");
            objBinario = Console.ReadLine();
            Console.WriteLine("El numero decimal ingresado, en binario es: {0}",((NumeroBinario)objDecimal).GetNumero());
            Console.WriteLine("El numero binario ingresado, en decimal es: {0}",((NumeroDecimal)objBinario).GetNumero());
            Console.ReadKey();
        }
    }
}
