using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace ClaseNumero2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota("Princesa", new DateTime(1987,1,12).Date, "Perro");
            Console.WriteLine(mascota1.MostrarDatos());
            Console.ReadKey();
        }
    }
}
