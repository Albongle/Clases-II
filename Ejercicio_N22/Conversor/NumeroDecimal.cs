using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class NumeroDecimal
    {
        private double numero;
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public double GetNumero()
        {
            return this.numero;
        }
        public string DecimalBinario(double valor)
        {
            string valorBinario = "";
            int resultDiv;
            int restoDiv;
            resultDiv = (int)valor;
            do
            {
                restoDiv = resultDiv % 2;
                resultDiv /= 2;
                valorBinario = restoDiv.ToString()+valorBinario;
            } while (resultDiv > 0);

            return valorBinario;
        }
        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator NumeroBinario(NumeroDecimal numero)
        {
            NumeroBinario returnAux;
            returnAux = numero.DecimalBinario(numero.numero);
            return returnAux;
        }
        public static bool operator ==(NumeroDecimal numeroDec,NumeroBinario numeroBin)
        {
            return numeroDec.numero == ((NumeroDecimal)numeroBin).numero;
        }
        public static bool operator !=(NumeroDecimal numeroDec, NumeroBinario numeroBin)
        {
            return !(numeroDec==numeroBin);
        }
        public static double operator +(NumeroDecimal numeroDec, NumeroBinario numeroBin)
        {
            return numeroDec.numero + ((NumeroDecimal)numeroBin).numero;
        }
        public static double operator -(NumeroDecimal numeroDec, NumeroBinario numeroBin)
        {
            return numeroDec.numero - ((NumeroDecimal)numeroBin).numero;
        }
    }
}
