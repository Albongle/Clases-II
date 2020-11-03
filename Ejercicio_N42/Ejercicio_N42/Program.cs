using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using IO;

namespace Ejercicio_N42
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            string nombreArchivo = fecha.ToString("yyyyMMdd-hhmm") + ".txt";
            try
            {
                OtraClase obj = new OtraClase();
                obj.MetodoInstancia();
            }
            catch(Exception ex)
            {
                ArchivoTexto.Guardar(nombreArchivo, ex.Message);
                while(ex.InnerException!=null)
                {
                    ex = ex.InnerException;
                    ArchivoTexto.Guardar(nombreArchivo, ex.Message);
                }
            }
            Console.WriteLine(ArchivoTexto.Leer(nombreArchivo));
            Console.ReadKey();
        }
    }
}
