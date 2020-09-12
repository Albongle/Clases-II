using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Celsius
    {
        private double temperatura;

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        public static implicit operator Celsius(double c)
        {
            return new Celsius(c);
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(((c.temperatura*9/5)+32));
        }
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin((((Fahrenheit)c).GetTemperatura()+ 459.67)*5/9);
        }

        //comparadores y aritmeticos
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return (c1.temperatura == c2.temperatura);
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return (c == (Celsius)k);
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return (c == (Celsius)f);
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.temperatura - ((Celsius)k).temperatura);
        }
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.temperatura - ((Celsius)f).temperatura);
        }
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.temperatura + ((Celsius)k).temperatura);
        }
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.temperatura + ((Celsius)f).temperatura);
        }
    }
}
