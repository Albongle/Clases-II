using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace ConexionBD
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductosDAO<Producto> productosDAO = new ProductosDAO<Producto>();
            Producto producto = new Producto();
            producto.Nombre = "Prety";
            producto.Codigo = "A005";
            producto.Precio = 128;

            productosDAO.InsertarElementos(producto);

            productosDAO.ActualizarElemento(6, "Modificado", "Codigo", 200);
            productosDAO.BorrarElemento(6);

            Console.WriteLine((productosDAO.ObtenerElementos(5)).ToString());
            
            Console.WriteLine("TERMINE");
            Console.ReadKey();
        }
    }
}
