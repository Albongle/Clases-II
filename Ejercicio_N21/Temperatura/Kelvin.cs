using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Kelvin
    {
        private double temperatura;
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        public static implicit operator Kelvin(double k)
        {
            return new Kelvin(k);
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius((((Fahrenheit)k).GetTemperatura()-32)*5/9);
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.temperatura * 9 / 5) - 459.67);
        }
        //comparadores y aritmeticos
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return (k1.temperatura == k2.temperatura);
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return (k == (Kelvin)c);
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return (k == (Kelvin)f);
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.temperatura - ((Kelvin)c).temperatura);
        }
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.temperatura - ((Kelvin)f).temperatura);
        }
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.temperatura + ((Kelvin)c).temperatura);
        }
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.temperatura + ((Kelvin)f).temperatura);
        }
    }
}
