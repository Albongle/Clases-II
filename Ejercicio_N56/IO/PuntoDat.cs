using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;
        public PuntoDat()
        {

        }
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
            return this.GuardarComo(ruta, objeto);
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            Stream stream = null;
            BinaryFormatter binaryFormatter = null;
            bool returnAux = false;
            if (ValidarArchivo(ruta, true))
            {
                try
                {
                    stream = new FileStream(ruta, FileMode.Create);
                    binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, objeto);
                    returnAux = true;
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
            return returnAux;
        }

        public PuntoDat Leer(string ruta)
        {
            Stream stream = null;
            BinaryFormatter binaryFormatter = null;
            PuntoDat returnAux = null;
            if (ValidarArchivo(ruta, true))
            {
                try
                {
                    returnAux = new PuntoDat();
                    stream = new FileStream(ruta, FileMode.Open);
                    binaryFormatter = new BinaryFormatter();
                    returnAux = (PuntoDat)binaryFormatter.Deserialize(stream);
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
            return returnAux;
        }
    }
}
