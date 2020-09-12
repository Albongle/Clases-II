 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Ej7
{
    class Ejercicios_Ej7
    {
        static void Main(string[] args)
        {
            DateTime ingresoFecha;
            DateTime fechaActual = DateTime.Today;
            Console.WriteLine("Ingrese la fecha de nacimiento:");
            DateTime.TryParse(Console.ReadLine(), out ingresoFecha);
            Console.WriteLine("Cantidad de dias vividos: {0}", (fechaActual - ingresoFecha).TotalDays);
            Console.ReadKey();
        }
    }
}
