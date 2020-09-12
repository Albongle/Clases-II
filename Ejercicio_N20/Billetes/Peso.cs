using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Peso()
        {
            cotizRespectoDolar = 74.44;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public static string SetCotizacion
        {
            set { cotizRespectoDolar = ValidaCotizacion(value); }
        }
        private static double ValidaCotizacion(string strCotizacion)
        {
            double returnAux;
            if (double.TryParse(strCotizacion, out returnAux))
            {
                return returnAux;
            }
            else
            {
                return -1;
            }
        }
        public static implicit operator Peso(string p)
        {
            return new Peso(ValidaCotizacion(p));
        }
        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.cantidad / Peso.GetCotizacion()));
        }
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p); 
        }
        //comparadores y aritmeticos
        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.cantidad == p2.cantidad);
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return (p == (Peso)d);
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return (p == (Peso)e);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }


    }
}
