using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;


namespace Ejercicio_N20
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro billeteUno = 1;
            Peso billeteDos = (Peso)billeteUno; 


            Console.WriteLine(billeteDos.GetCantidad());
            Console.ReadKey();

        }
    }
}
