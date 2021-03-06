﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
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
            if(double.TryParse(strCotizacion, out returnAux))
            {
                return returnAux;
            }
            else
            {
                return -1;
            }
        }
        public static implicit operator Dolar(string d)
        {
            return new Dolar(ValidaCotizacion(d));
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.cantidad * Euro.GetCotizacion()));
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso((d.cantidad * Peso.GetCotizacion()));
        }
        //comparadores y aritmeticos
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d==(Dolar)e);
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return (d == (Peso)p);
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad- ((Dolar)p).cantidad);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }
    }
}
