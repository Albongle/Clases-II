using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N57
{
    class Program
    {
        static void Main(string[] args)
        {
            string archivo = "AchivoXML.xml";
            Persona persona = new Persona("Alejandro", "Bongioanni");
            Persona.Guardar(persona);
            Console.WriteLine((Persona.Leer(archivo)).ToString());
            Console.ReadKey();
        }
    }
}
