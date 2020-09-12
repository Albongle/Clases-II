using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidadaes
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
           this.marca = marca;
           this.precio = precio;
           this.codigoDeBarra = codigo;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostarProdcuto(Producto p)
        {
            return "Marca: " + p.marca + " Precio: " + p.precio + " Codigo de Barra: " + p.codigoDeBarra;
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca== marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1==p2);
        }
    }
}
