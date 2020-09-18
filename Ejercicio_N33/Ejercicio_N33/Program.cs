using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libro;

namespace Ejercicio_N33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libros nuevoLibro= new Libros();

            nuevoLibro[0] = "Pagina";
            Console.WriteLine(nuevoLibro[0]);
            nuevoLibro[0] = "Pagina 2";
            Console.WriteLine(nuevoLibro[0]);
            nuevoLibro[1] = "Pagina 3";
            Console.WriteLine(nuevoLibro[1]);
            Console.ReadKey();
        }
    }
}
