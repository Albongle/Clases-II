using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Verduleria
{
    public class Producto
    {
        private string verdura;
        private float precio;
        public Producto(float precio)
        {
            this.precio = precio;
        }

        public static bool operator == (Producto p1, float precio)
        {
            return p1.precio == precio;
        }
        public static bool operator !=(Producto p1, float precio)
        {
            return !(p1==precio);
        }

        public static implicit operator Producto(float precio)
        {
            return new Producto(precio);
        }
        public static explicit operator float (Producto producto)
        {
            return producto.precio;
        }

    }
}
