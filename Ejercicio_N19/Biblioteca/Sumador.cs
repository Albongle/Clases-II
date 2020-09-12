using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador() : this(0)
        {
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public static explicit operator int (Sumador suma) //Generar una conversión explícita que retorne cantidadSumas.
        {
            return suma.cantidadSumas;
        }
        public static long operator + (Sumador a, Sumador b) //Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor.
        {
            return a.cantidadSumas + b.cantidadSumas;
        }
        public static bool operator |(Sumador a, Sumador b) //Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas.
        {
            return a.cantidadSumas == b.cantidadSumas;
        }
    


    }
}
