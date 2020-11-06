using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido { get { return this.contenido; } set {this.contenido=value;} }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            string extension = ruta.Substring((ruta.Length - 4), 4);
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia) && extension == ".dat")
                {
                    return true;
                }
                else
                {
                    throw new ArchivoIncorrectoException("El archivo no es un DAT");
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", ex);
            }
        }
        public bool Guardar(string ruta, PuntoDat objeto)
        {
            throw new NotImplementedException();
        }

        public bool GuardarComo(string ruta, PuntoDat Objeto)
        {
            throw new NotImplementedException();
        }

        public PuntoDat Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
