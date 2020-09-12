using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class NumeroBinario
    {
        private string numero;
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        public string GetNumero()
        {
            return this.numero;
        }
        public double BinarioDecimal(string valorRecibido)
        {
            double resultado = 0;
            int cantidadCaracteres = valorRecibido.Length;
            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado+= Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }
        public static explicit operator NumeroDecimal(NumeroBinario numero)
        {
            NumeroDecimal returnAux;
            returnAux = numero.BinarioDecimal(numero.numero);
            return returnAux;
        }
        public static bool operator ==(NumeroBinario numeroBin, NumeroDecimal numeroDec)
        {
            return numeroBin.numero==((NumeroBinario)numeroDec).numero;
        }
        public static bool operator !=(NumeroBinario numeroBin, NumeroDecimal numeroDec)
        {
            return !(numeroBin==numeroDec);
        }
        public static string operator +(NumeroBinario numeroBin, NumeroDecimal numeroDec)
        {
            return numeroDec.DecimalBinario(((NumeroDecimal)numeroBin).GetNumero() + numeroDec.GetNumero());
        }
        public static string operator -(NumeroBinario numeroBin, NumeroDecimal numeroDec)
        {
            return numeroDec.DecimalBinario(((NumeroDecimal)numeroBin).GetNumero() - numeroDec.GetNumero());
        }
    }

}
