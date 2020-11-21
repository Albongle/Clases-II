using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class BaseDeDatos
    {
        private SqlConnection sqlConnection;
        private string CadenaConexion;

        public BaseDeDatos()
        {
            this.CadenaConexion = "Server=.;Database=Facultad;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(this.CadenaConexion);
        }


        public void Guardar(object objeto)
        {
            try
            {
                string query = "INSERT INTO Personas (nombre,apellido) VALUES (@nombre,@apellido)";
                SqlCommand sqlCommand = new SqlCommand(query, this.sqlConnection);
                //sqlCommand.Parameters.AddWithValue("id", persona.Id);
                sqlCommand.Parameters.AddWithValue("nombre", objeto.ToString()); //remplazar por lo que se quiera enviar como parametro a la BD
                sqlCommand.Parameters.AddWithValue("apellido", objeto.ToString());
                if(this.sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    this.sqlConnection.Open();
                }
                sqlCommand.ExecuteNonQuery();

            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void Modificar(int id, string nombre, string apellido)
        {
            try
            {
                string sentencia = "UPDATE Personas SET nombre=@nombre,apellido=@apellido where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", nombre);
                sqlCommand.Parameters.AddWithValue("apellido", apellido);
                sqlCommand.Parameters.AddWithValue("id", id);
                if (this.sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    this.sqlConnection.Open();
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

        public void Borrar(int id)
        {
            try
            {
                string sentencia = "DELETE FROM Personas where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                if (this.sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    this.sqlConnection.Open();
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

        public object LeerPorId(int id)
        {
            try
            {
                string sentencia = "SELECT * FROM Personas where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                if (this.sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    this.sqlConnection.Open();
                }
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                object objeto = new object(); //Es lo que voy a retornar, EJ: new Persona(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2));
                return objeto;
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        public List<object> Leer()
        {
            try
            {
                string sentencia = "SELECT * FROM Personas";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                if (this.sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    this.sqlConnection.Open();
                }
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                List<object> objetos = new List<object>();
                while (sqlDataReader.Read())
                {
                    object objeto = new object(); //EJ: new Persona(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2));
                    objetos.Add(objeto);
                }
                return objetos;
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }


    }
}
