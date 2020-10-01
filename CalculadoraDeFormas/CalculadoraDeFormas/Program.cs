using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace CalculadoraDeFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaFiguras = new List<Figura>();

            listaFiguras.Add(new Circulo(10));
            listaFiguras.Add(new Cuadrado(7));
            listaFiguras.Add(new Rectangulo(12,6));

            foreach (Figura figura in listaFiguras)
            {
                Console.WriteLine("Tipo: {0}", figura.GetType());
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine("Area: {0}", figura.CalcularSuperficie().ToString("0.00"));
                Console.WriteLine("Perimetro: {0}", figura.CalcularPerimetro().ToString("0.00"));
                Console.WriteLine("------------------------------\n\n");
            }

            Console.ReadKey();

        }
    }
}
