using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N47
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------futbol-----------------------------------------------//
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Liga Profesional de Futbol");
            EquipoFutbol independiente = new EquipoFutbol("Independiente", new DateTime(1905,01,01));
            EquipoFutbol racing = new EquipoFutbol("Racing", new DateTime(1903,03,25));
            EquipoFutbol boca= new EquipoFutbol("Boca", new DateTime(1905,04,03));
            EquipoFutbol river = new EquipoFutbol("River", new DateTime(1901,05,25));
            torneoFutbol += independiente;
            torneoFutbol += racing;
            torneoFutbol += boca;
            torneoFutbol += river;
            Console.WriteLine("-------------------------------Futbol-----------------------------------------------");
            Console.WriteLine(torneoFutbol.ToString());
            Console.WriteLine($"Resultadodo de la fecha [{torneoFutbol.JugarPartido}]");
            //------------------------------basquet-----------------------------------------------//
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");
            EquipoBasquet LAL = new EquipoBasquet("Los Angeles Lakers", new DateTime(1946, 11, 05));
            EquipoBasquet SAS = new EquipoBasquet("San Antonio Spurs", new DateTime(1967, 03, 23));
            EquipoBasquet CHB = new EquipoBasquet("Chicago Bulls", new DateTime(1966, 01, 16));
            EquipoBasquet NYK = new EquipoBasquet("New York Knicks", new DateTime(1946, 06, 06));
            torneoBasquet += LAL;
            torneoBasquet += SAS;
            torneoBasquet += CHB;
            torneoBasquet += NYK;
            Console.WriteLine("-------------------------------Basquet-----------------------------------------------");
            Console.WriteLine(torneoBasquet.ToString());
            Console.WriteLine($"Resultadodo de la fecha [{torneoBasquet.JugarPartido}]"); ;

            Console.ReadKey();

        }
    }
}
