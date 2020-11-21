using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class Archivos<T> where T : new()
    {

        //Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //File.Exists() verifica si existe
        //File.Copy() copia un arhivo en uno nuevo
        //File.Delete Elimina el archivo
        //Directory.Exists() determina si existe la ruta
        //Directory.CreateDirectory() crea directorio

        public bool LeerXML(string nombreArchivo, out T objeto)
        {
            bool returnAux = false;
            XmlTextReader xmlReader = null;
            XmlSerializer serializer = null;
            try
            {
                xmlReader = new XmlTextReader($"{nombreArchivo}");
                serializer = new XmlSerializer(typeof(T));
                objeto = (T)serializer.Deserialize(xmlReader);
                returnAux = true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer", ex);
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
        public void GuardarXML(string nombreArchivo, T objeto)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(nombreArchivo, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar", ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }


        public string LeerTexto(string ruta, string nombre)
        {
            StreamReader streamRead = null;
            try
            {
                streamRead = new StreamReader(ruta);
                string text = string.Empty;
                string newLine = streamRead.ReadLine();
                while (newLine != null)
                {
                    text += newLine + "\n";
                    newLine = streamRead.ReadLine(); // o usar streamRead.ReadToEnd()
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

        public void GuardarTexto(string ruta, string texto)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(ruta, true);
                streamWriter.WriteLine(texto);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }

        public bool GuardarBinario(string ruta, T objeto)
        {
            Stream stream = null;
            BinaryFormatter binaryFormatter = null;
            bool returnAux = false;
            try
            {
                stream = new FileStream(ruta, FileMode.Create);
                binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objeto);
                returnAux = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return returnAux;
        }

        public T LeerBinario(string ruta)
        {
            Stream stream = null;
            BinaryFormatter binaryFormatter = null;
            try
            {
                T returnAux = new T();
                stream = new FileStream(ruta, FileMode.Open);
                binaryFormatter = new BinaryFormatter();
                returnAux = (T)binaryFormatter.Deserialize(stream);
                return returnAux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }


    }
}
