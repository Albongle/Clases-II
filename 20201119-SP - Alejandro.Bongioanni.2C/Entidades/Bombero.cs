using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{


    public delegate void FinDeSalida(int bonberoindex);

    [Serializable]
    public class Bombero : IArchivos<Bombero>, IArchivos<string>
    {
        [NonSerialized]
        static string CadenaConexion;
        [NonSerialized]
        static SqlConnection sqlConnection;
        private string nombre;
        private List<Salidas> salidas;

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

        public event FinDeSalida MarcarFin;

        static Bombero()
        {
            CadenaConexion = "Server=.;Database=20201119-sp;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(CadenaConexion);
        }
        public Bombero()
        {
            salidas = new List<Salidas>();
        }
        public Bombero(string nombre)
            : this()
        {
            this.nombre = nombre;

        }

        public void Guardar(Bombero info)
        {
            Stream stream = null;
            BinaryFormatter binaryFormatter = null;
            try
            {
                stream = new FileStream("BomberoSerializado.xml", FileMode.Create);
                binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, info);
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

        public Bombero Leer()
        {
            Stream stream = null;
            BinaryFormatter binaryFormatter = null;
            try
            {
                Bombero returnAux = new Bombero();
                stream = new FileStream("BomberoSerializado.xml", FileMode.Open);
                binaryFormatter = new BinaryFormatter();
                returnAux = (Bombero)binaryFormatter.Deserialize(stream);
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

        void IArchivos<string>.Guardar(string info)
        {
            try
            {
                string query = "INSERT INTO log (entrada,alumno) VALUES (@entrada,@alumno)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("entrada", info);
                sqlCommand.Parameters.AddWithValue("alumno", "Bongioanni");
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                sqlCommand.ExecuteNonQuery();

            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        string IArchivos<string>.Leer()
        {
            string returnAux = string.Empty;
            try
            {
                string sentencia = "SELECT * FROM log";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    returnAux += sqlDataReader.GetString(0);
                }
                return returnAux;
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }
        public void AtenderSalida(object bomberoindex)
        {
            Salidas salidas = new Salidas();
            this.salidas.Add(salidas);
            Thread.Sleep(4000);
            salidas.FinalizarSalida();
            this.MarcarFin.Invoke((int)bomberoindex);
        }

    }
}
