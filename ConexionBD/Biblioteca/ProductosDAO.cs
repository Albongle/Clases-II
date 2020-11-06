using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ProductosDAO <T> where T:Producto, new()
    {
        private SqlConnection sqlConnection;
        public ProductosDAO()
        {
            string conexion= "Server=.;Database=ProductosDB;Trusted_Connection=True;";
            this.sqlConnection = new SqlConnection(conexion);
        }

        public void InsertarElementos(T Objeto)
        {
            try
            {
                string sentencia = "INSERT INTO Productos (nombre,codigo,precio) VALUES (@nombre,@codigo,@precio)";
                SqlCommand sqlCommand = new SqlCommand(sentencia, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", Objeto.Nombre);
                sqlCommand.Parameters.AddWithValue("codigo", Objeto.Codigo);
                sqlCommand.Parameters.AddWithValue("precio", Objeto.Precio);
                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if(this.sqlConnection !=null && sqlConnection.State== System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        /// <summary>
        /// Actauliza por ID
        /// </summary>
        /// <param name="id">Es el ID a actualizar</param>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        public void ActualizarElemento(int id, string nombre, string codigo, float precio)
        {
            try
            {
                string sentencia = "UPDATE Productos SET nombre=@nombre,codigo=@codigo,precio=@precio where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", nombre);
                sqlCommand.Parameters.AddWithValue("codigo", codigo);
                sqlCommand.Parameters.AddWithValue("precio", precio);
                sqlCommand.Parameters.AddWithValue("id",id);
                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (this.sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }
        public void BorrarElemento(int id)
        {
            try
            {
                string sentencia = "DELETE FROM Productos where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (this.sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public T ObtenerElementos(int id)
        {
            try
            {
                string sentencia = "SELECT * FROM Productos where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                this.sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //List<T> elementos = new List<T>();
                T producto = new T();
                while(sqlDataReader.Read())
                {
                    producto.Id = sqlDataReader.GetInt32(0);
                    producto.Nombre = sqlDataReader.GetString(2);
                    producto.Codigo = sqlDataReader.GetString(1);
                    producto.Precio = (float)Convert.ToDouble(sqlDataReader["precio"]);
                }
                return producto;
            }
            finally
            {
                if (this.sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }
    }
}
