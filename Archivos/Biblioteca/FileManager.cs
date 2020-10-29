using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class FileManager
    {
        public void EscribirArchivoTexto(string ruta, string nombre, string texto, bool anexar)
        {
            StreamWriter streamWriter = null;
            try
            {
                string rutaCompleta = ruta+"\\" + nombre + ".txt";
                streamWriter = new StreamWriter(rutaCompleta, anexar);
                streamWriter.WriteLine(texto);                
            }
            finally
            {
                if (streamWriter!=null)
                {
                    streamWriter.Close();
                }               
            }
        }
        public string LeerArchivoTexto(string ruta, string nombre)
        {
            StreamReader streamRead = null;
            try
            {
                string rutaCompleta = ruta + "\\" + nombre + ".txt";
                streamRead = new StreamReader(rutaCompleta);
                string text = string.Empty;
                string newLine = streamRead.ReadLine();
                while (newLine!=null)
                {
                    text += newLine + "\n";
                    newLine = streamRead.ReadLine();
                }
                return text;

            }
            finally
            {
                if (streamRead != null)
                {
                    streamRead.Close();
                }
            }
        }
    }
}
