using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N17
{
    class Ejercicio_N17
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal; // guardo el colo de la tipografia original
            string dibujo;
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 3);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);
            colorOriginal = Console.ForegroundColor; //le asigno el color del boligrafo a la tipografia de la consola
            Console.ForegroundColor = boligrafoAzul.GetColor();
            boligrafoAzul.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine("El nivel de tinta del boligrafo azul es {0}", boligrafoAzul.GetTinta());
            boligrafoAzul.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);
            Console.ReadKey();
        }
    }
}
