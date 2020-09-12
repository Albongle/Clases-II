using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ10
{
    class Ejercicios_EJ10
    {
        static void Main(string[] args)
        {
            int altura;
            string aux;
            Console.WriteLine("Ingrese la altura de la piramide:");
            int.TryParse(Console.ReadLine(), out altura);
            Console.WriteLine();
            for (int i = 0; i < altura; i++)
            {
                aux = "";
                for (int j = 0; j <= (i * 2); j++)
                {
                    aux += "*";                 
                }
                Console.Write(StringCentering(aux, (altura*2)));
                Console.WriteLine();

            }
            Console.ReadKey();
        }
        static string StringCentering(string s, int desiredLength)
        {
            if (s.Length >= desiredLength)
            {
                return s;
            }
            int firstpad = (s.Length + desiredLength) / 2;
            return s.PadLeft(firstpad).PadRight(desiredLength);
        }
    }
}
