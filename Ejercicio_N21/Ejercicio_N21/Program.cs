using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperatura;

namespace Ejercicio_N21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius temp;
            Kelvin temp2;
            Fahrenheit temp3;
            double aux;
            Console.WriteLine("Ingrese la temperatura en Celsius:");
            double.TryParse(Console.ReadLine(), out aux);
            temp = aux;
            temp2 = (Kelvin)temp;
            temp3 = (Fahrenheit)temp;
            Console.WriteLine("La temperatura en K es {0}", temp2.GetTemperatura());
            Console.WriteLine("La temperatura en F es {0}", temp3.GetTemperatura());
            Console.WriteLine("Ingrese la temperatura en Kelvin:");
            double.TryParse(Console.ReadLine(), out aux);
            temp2 = aux;
            temp = (Celsius)temp2;
            temp3 = (Fahrenheit)temp2;
            Console.WriteLine("La temperatura en C es {0}", temp.GetTemperatura());
            Console.WriteLine("La temperatura en F es {0}", temp3.GetTemperatura());
            Console.WriteLine("Ingrese la temperatura en Fahrenheit:");
            double.TryParse(Console.ReadLine(), out aux);
            temp3 = aux;
            temp = (Celsius)temp3;
            temp2 = (Kelvin)temp3;
            Console.WriteLine("La temperatura en C es {0}", temp.GetTemperatura());
            Console.WriteLine("La temperatura en K es {0}", temp2.GetTemperatura());


            Console.ReadKey();
        }
    }
}
