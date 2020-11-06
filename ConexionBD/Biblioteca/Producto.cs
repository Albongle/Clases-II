using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        public Producto()
        {

        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre{ get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }


        public override string ToString()
        {
            return $"id {this.Id} codigo {Codigo} nombre {this.Nombre} precio {this.Precio}"; 
        }
    }
}
