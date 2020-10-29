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
        public static void EscribirArchivoTexto(string ruta, string texto, bool anexar)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(ruta, anexar);
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
        public static string LeerArchivoTexto(string ruta)
        {
            StreamReader streamRead = null;
            try
            {
                streamRead = new StreamReader(ruta);
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
