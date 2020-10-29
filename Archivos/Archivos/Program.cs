using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Hola Mundo";
            string nombreArchivo = "clase_19";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileManager nuevoArchivo = new FileManager();
            nuevoArchivo.EscribirArchivoTexto(path,nombreArchivo,texto,true);
        }
    }
}
