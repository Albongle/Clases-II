using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            string extension = ruta.Substring((ruta.Length - 4), 4);
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia) && extension == ".txt")
                {
                    return true;
                }
                else
                {
                    throw new ArchivoIncorrectoException("El archivo no es un TXT");
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", ex);
            }

        }
        public bool Guardar(string ruta, string objeto)
        {
            bool returnAux = false;
            if (this.ValidarArchivo(ruta, true))
            {
                FileManager.EscribirArchivoTexto(ruta, objeto, true);
                returnAux = true;
            }

            return returnAux;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            FileManager.EscribirArchivoTexto(ruta, objeto, false);           
            return true;
        }

        public string Leer(string ruta)
        {
            string returnAux = string.Empty;
            if (this.ValidarArchivo(ruta, true))
            {
                returnAux = FileManager.LeerArchivoTexto(ruta);
            }
            return returnAux;
        }
    }
}
