using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            Moto.valorHora = 30;
        }
        public Moto (string patente, int cilindrada)
            :this(patente, cilindrada,2)
        {

        }
        public Moto (string patente, int cilindrada, short ruedas)
            :base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;           
        }
        public Moto(string patente, int cilidrada, short ruedas, int valorHora)
            :this(patente,cilidrada,ruedas)
        {
            Moto.valorHora = valorHora;
        }
        public override bool Equals(object obj)
        {
            return (obj is Moto);
        }
        public override string ConsultarDatos()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("Patente: "+ base.Patente);
            returnAux.AppendLine("Cilindrada: " + this.cilindrada);
            returnAux.AppendLine("Cantidad de ruedas " + this.ruedas);
            return returnAux.ToString();
        }
        public override string ImprimirTicket()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine(base.ImprimirTicket());
            returnAux.AppendLine(this.ConsultarDatos());
            returnAux.AppendLine("Costo de la Estadia: "+(DateTime.Now.Hour - base.ingreso.Hour) * Moto.valorHora);
            return returnAux.ToString();
        }
    }
}
