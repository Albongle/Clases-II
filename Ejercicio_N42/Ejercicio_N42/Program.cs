using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase obj = new OtraClase();
                obj.MetodoInstancia();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                while(ex.InnerException!=null)
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);                                      
                }
            }

            Console.ReadKey();
        }
    }
}
