using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T> where T: new()
    {
        public void Guardar(string nombreArchivo, T objeto)
        {
            Guardar(nombreArchivo, objeto, Encoding.UTF8);
        }

        public bool FileExists(string nombreArchivo)
        {
            return File.Exists($"{this.GetDirectoryPath}{nombreArchivo}");
        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(nombreArchivo, encoding);
                writer.Formatting = Formatting.Indented;
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("Error al guardar", ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            bool returnAux = false;
            if (Leer(nombreArchivo, out objeto, Encoding.UTF8))
            {
                returnAux = true;
            }
            return returnAux;
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            bool returnAux = false;
            XmlTextReader xmlReader = null;
            XmlSerializer serializer = null;
            try
            {

                xmlReader = new XmlTextReader($"{this.GetDirectoryPath}{nombreArchivo}");
                serializer = new XmlSerializer(typeof(T));
                objeto = (T)serializer.Deserialize(xmlReader, encoding.EncodingName);
                returnAux = true;

            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("Error al leer", ex);
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
            }
            return returnAux;
        }

        public string GetDirectoryPath
        {
            get
            {
                return $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
            }
        }
    }
}
