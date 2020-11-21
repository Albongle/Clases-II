using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja Caja1 = new Caja();
            Caja Caja2 = new Caja();
            Negocio nuevoNegocio = new Negocio(Caja1, Caja2);


            Thread threadAsignar= new Thread(nuevoNegocio.AsignarCaja);
            Thread threadAtenderCaja1 = new Thread(Caja1.AtenderClientes);
            Thread threadAtenderCaja2 = new Thread(Caja2.AtenderClientes);
            threadAtenderCaja1.Name = "CAJA 1";
            threadAtenderCaja2.Name = "CAJA 2";

            threadAsignar.Start();
            threadAsignar.Join();
            Console.WriteLine("--------------Atendiendo------------------------");
            threadAtenderCaja1.Start();
            threadAtenderCaja2.Start();

            Console.ReadKey();


        }
    }
}
