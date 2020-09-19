using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(4, 5, VehiculoTerrestre.Colores.Azul, 6, 5);
            Console.WriteLine(auto.MostrarDatos());
            Console.ReadKey();
        }
    }
}
