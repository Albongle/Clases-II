using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadaes
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) :this (capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public static string MostrarEstante(Estante e)
        {
            string returnAux = string.Empty;
            foreach (Producto productoAux in e.productos)
            {
                if (!(object.ReferenceEquals(productoAux, null)))
                {
                    returnAux += Producto.MostarProdcuto(productoAux) + "\n";
                }
            }
            return returnAux;
        }
        public Producto[] GetProducto()
        {
            return this.productos;
        }
        public static bool operator == (Estante e, Producto p)
        {
            bool returnAux = false;
            foreach (Producto productoAux in e.productos)
            {
                if(!(object.ReferenceEquals(productoAux, null)))
                {
                    if (productoAux == p)
                    {
                        returnAux = true;
                        break;
                    }
                }
            }
            return returnAux;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool returnAux = false;
            for (int i = 0; i < (e.productos.Length); i++)
            {
                if(object.ReferenceEquals(e.productos[i], null) && e != p)
                {
                    e.productos[i] = p;
                    returnAux = true;
                }
            }
            return returnAux;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            Estante estanteAux = e;
            for (int i = 0; i < (estanteAux.productos.Length); i++)
            {
                if (e==p)
                {
                    estanteAux.productos[i] = null;
                }
            }
            return estanteAux;
        }
    }
}
