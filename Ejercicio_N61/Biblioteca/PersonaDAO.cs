using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class PersonaDAO
    {
        /// <summary>
        /// Parametro de tipo SqlConnection que establece la conexion a la BD
        /// </summary>
        private static SqlConnection sqlConnection;
        /// <summary>
        /// Constructor que genera la instancia de conexion a la BD
        /// </summary>
        static PersonaDAO()
        {
            string conexion = "Server=.;Database=Facultad;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(conexion);
        }

        /// <summary>
        /// Guarda los datos de una persona en la BD
        /// </summary>
        /// <param name="persona">Es la persona a guardar</param>
        public static void Guardar(Persona persona)
        {
            try
            {
                string sentencia = "INSERT INTO Personas (nombre,apellido) VALUES (@nombre,@apellido)";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                //sqlCommand.Parameters.AddWithValue("id", persona.Id);
                sqlCommand.Parameters.AddWithValue("nombre", persona.Nombre);
                sqlCommand.Parameters.AddWithValue("apellido", persona.Apellido);
                sqlConnection.Open();
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
        /// <summary>
        /// Modifica los datos de una persona segun su ID
        /// </summary>
        /// <param name="id">Es el ID a modificar</param>
        /// <param name="nombre">Es el nombre nuevo</param>
        /// <param name="apellido">Es el apellido nuevo</param>
        public static void Modificar(int id, string nombre, string apellido)
        {
            try
            {
                string sentencia = "UPDATE Personas SET nombre=@nombre,apellido=@apellido where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", nombre);
                sqlCommand.Parameters.AddWithValue("apellido", apellido);
                sqlCommand.Parameters.AddWithValue("id", id);
                sqlConnection.Open();
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
        /// <summary>
        /// Borra un elemento de la BD segun su ID
        /// </summary>
        /// <param name="id">Es el ID a buscar y borrar</param>
        public static void Borrar(int id)
        {
            try
            {
                string sentencia = "DELETE FROM Personas where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                sqlConnection.Open();
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
        /// <summary>
        /// Lee los elementos de la tabla Persona segun su ID
        /// </summary>
        /// <param name="id">Es el Id de la persona a buscar</param>
        /// <returns>Una Persona</returns>
        public static Persona LeerPorId(int id)
        {
            try
            {
                string sentencia = "SELECT * FROM Personas where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                Persona persona = new Persona(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2));
                return persona;
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        /// <summary>
        /// Lee todos los elementos de la tabla Persona y los retorna en una lista
        /// </summary>
        /// <returns>Una Lista de Personas</returns>
        public static List<Persona> Leer()
        {
            try
            {
                string sentencia = "SELECT * FROM Personas";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                List<Persona> personas = new List<Persona>();
                while (sqlDataReader.Read())
                {
                    Persona persona = new Persona(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2));
                    personas.Add(persona);
                }
                return personas;
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
