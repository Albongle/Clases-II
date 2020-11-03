using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoTexto
    {
        public static bool Guardar (string nombreArchivo, string texto)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(nombreArchivo, true);
                streamWriter.WriteLine(texto);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
            return true;
        }
        public static string Leer (string nombreArchivo)
        {
            StreamReader streamReader = null;
            string textoLeido=string.Empty;
            try
            {
                streamReader = new StreamReader(nombreArchivo);
                textoLeido=streamReader.ReadToEnd();
                return textoLeido;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(streamReader!=null)
                {
                    streamReader.Close();
                }
            }
        }
    }
}
