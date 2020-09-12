using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;


        static Euro()
        {
            cotizRespectoDolar = 1 / 1.18;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
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
        public static implicit operator Euro(string e)
        {
            return new Euro(ValidaCotizacion(e));
        }
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        //comparadores y aritmeticos
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e == (Euro)d);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return (e == (Euro)p);
        }
        public static bool operator !=(Euro e,Peso p)
        {
            return !(e == p);
        }
        public static Euro operator -(Euro e , Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

    }
}
