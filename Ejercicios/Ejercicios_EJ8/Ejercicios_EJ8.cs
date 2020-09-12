using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ8
{
    class Ejercicios_EJ8
    {
        static void Main(string[] args)
        {
            int valorHora;
            string nombreEmpleado;
            int antiguedad;
            int cantidadHoras;

            Console.WriteLine("Ingrese valor hora:");
            int.TryParse(Console.ReadLine(), out valorHora);
            Console.WriteLine("Ingrese el nombre del empleado:");
            nombreEmpleado = Console.ReadLine();
            Console.WriteLine("Ingrese la antigüedad en años:");
            int.TryParse(Console.ReadLine(), out antiguedad);
            Console.WriteLine("Ingrese la cantidad de horas trabajas en el mes");
            int.TryParse(Console.ReadLine(), out valorHora);
            nombreEmpleado.ToUpper();



        }
    }
}
