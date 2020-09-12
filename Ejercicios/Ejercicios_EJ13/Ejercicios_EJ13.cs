using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicios_EJ13
{
    class Ejercicios_EJ13
    {
        static void Main(string[] args)
        {

            int ingresoDecimal;
            string ingresoBinario;
            string binario;
            int numDecimal;
            Console.WriteLine("Ingrese el numero en decimal:");
            int.TryParse(Console.ReadLine(), out ingresoDecimal);          
            binario= Conversor.DecimalBinario(ingresoDecimal);
            binario = Conversor.Invertir(binario);
            Console.WriteLine("El resultado en binario es {0}", binario);
            Console.WriteLine("Ingrese el numero en Binario:");
            ingresoBinario=Console.ReadLine();
            numDecimal = Conversor.BinarioDecimal(ingresoBinario);
            Console.WriteLine("El resultado en Decimal es {0}", numDecimal);
            Console.ReadKey();
        }
    }
}
