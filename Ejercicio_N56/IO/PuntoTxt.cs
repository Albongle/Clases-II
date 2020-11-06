using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<PuntoTxt>
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
            catch(FileNotFoundException ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto",ex);
            }
                      
        }
        public bool Guardar(string ruta, PuntoTxt objeto)
        {
            throw new NotImplementedException();
        }

        public bool GuardarComo(string ruta, PuntoTxt Objeto)
        {
            throw new NotImplementedException();
        }

        public PuntoTxt Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
