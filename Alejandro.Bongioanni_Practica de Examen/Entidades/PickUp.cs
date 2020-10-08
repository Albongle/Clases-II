using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp: Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        public PickUp (string patente, string modelo)
            :base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHora)
            :this (patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string ImprimirTicket()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine(base.ImprimirTicket());
            returnAux.AppendLine(this.ConsultarDatos());
            returnAux.AppendLine("Costo de la Estadia: " + (DateTime.Now.Hour - base.ingreso.Hour) * PickUp.valorHora);
            return returnAux.ToString();
        }
        public override string ConsultarDatos()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("Patente: " + base.Patente);
            returnAux.AppendLine("Modelo: " + this.modelo);
            return returnAux.ToString();
        }
        public override bool Equals(object obj)
        {
            return (obj is PickUp);
        }
    }
}
