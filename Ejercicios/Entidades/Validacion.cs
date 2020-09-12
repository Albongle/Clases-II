using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Entidades
{
    public class ValidarNumero
    {
        public static bool ValidarInt(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char caracter)
        {
            bool retunrAux=false;
            if(caracter=='s' || caracter == 'S')
            {
                retunrAux = true;
            }
            return retunrAux;
        }
    }

    public class Conversor
    {
        public static string DecimalBinario(int valor)
        {
            string valorBinario="";
            int resultDiv;
            int restoDiv;
            resultDiv = valor;
            do
            {
                restoDiv = resultDiv % 2;
                resultDiv /= 2;
                valorBinario += restoDiv;
            } while (resultDiv > 0);

            return valorBinario;
        }
        public static int BinarioDecimal(string valorRecibido)
        {
            int resultado = 0;
            int potencia;
            int numeroBase;
            int cantidadCaracteres = valorRecibido.Length;
            foreach(char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter=='1')
                {
                    numeroBase = 2;
                    potencia = 1;
                    for (int i=0; i<cantidadCaracteres; i++)
                    {
                        potencia *= numeroBase;
                    }
                    resultado += potencia;
                }
            }
            return resultado;
        }
        public static string Invertir(string cadena)
        {
            string cadenaInvertida = "";
            foreach (char caracter in cadena)
            {
                cadenaInvertida = caracter + cadenaInvertida;
            }
            return cadenaInvertida;
        }

    }
    public class CalculoDeArea
    {
        public static double CalculaCuadrado (double valorBase)
        {
            double returnAux;
            returnAux = Math.Pow(valorBase, 2);
            return returnAux;
        }
        public static double CalcularTriangulo (double valorBase, double valorAltura)
        {
            double returnAux;
            returnAux = (valorBase * valorAltura) / 2;
            return returnAux;
        }

        public static double CalcularCirculo (double valorRadio)
        {
            double returnAux;
            returnAux = Math.PI * Math.Pow(valorRadio, 2);
            return returnAux;
        }
    }

    public class Calculadora
    {
        public static float Calcular (int operandoA, int operandoB, char operador)
        {
            float returnAux = 0; ;
            switch(operador)
            {
                case '+':
                    {
                        returnAux = operandoA + operandoB;
                        break;
                    }
                case '*':
                    {
                        returnAux = operandoA * operandoB;
                        break;
                    }
                case '/':
                    {
                        if(Validar(operandoB))
                        {
                            returnAux = operandoA / operandoB;
                        }
                        break;
                    }
                case '-':
                    {
                        returnAux = operandoA - operandoB;
                        break;
                    }
            }
            return returnAux;
        }
        private static bool Validar (int operadorB)
        {
            bool returnAux = false;
            if(operadorB !=0)
            {
                returnAux = true;
            }
            return returnAux;
        }
    }
}
