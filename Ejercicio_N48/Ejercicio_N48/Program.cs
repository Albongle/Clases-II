using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N48
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Factura[] factura = new Factura[10];
            Recibo [] recibo = new Recibo[10];
            Contabilidad<Factura,Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            for (int i = 0; i < 10; i++)
            {
                factura[i] = new Factura(random.Next(0, 99999));
                recibo[i] = new Recibo(random.Next(0, 99999));
                contabilidad += factura[i];
                contabilidad += recibo[i];
            }

            Console.WriteLine(contabilidad.ToString());
            Console.ReadKey();
        }
    }
}
