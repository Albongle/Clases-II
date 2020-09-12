using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Fahrenheit
    {
        private double temperatura;
        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        public static implicit operator Fahrenheit(double f)
        {
            return new Fahrenheit(f);
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.temperatura - 32) * 5 / 9);
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.temperatura+ 459.67) * 5 / 9);
        }
        //comparadores y aritmeticos
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return (f1.temperatura == f2.temperatura);
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return (f == (Fahrenheit)c);
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return (f == (Fahrenheit)k);
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.temperatura - ((Fahrenheit)c).temperatura);
        }
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.temperatura - ((Fahrenheit)k).temperatura);
        }
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.temperatura + ((Fahrenheit)c).temperatura);
        }
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.temperatura + ((Fahrenheit)k).temperatura);
        }


    }
}
