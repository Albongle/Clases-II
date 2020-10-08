using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;
        static Automovil()
        {
            Automovil.valorHora = 50;
        }
        public Automovil (string patente, ConsoleColor color)
            :base(patente)
        {
            this.color = color;
        }
        public Automovil(string patente, ConsoleColor color, int valorHora)
            :this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("Patente: " + base.Patente);
            returnAux.AppendLine("Color: " + this.color);
            return returnAux.ToString();
        }
        public override string ImprimirTicket()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine(base.ImprimirTicket());
            returnAux.AppendLine(this.ConsultarDatos());
            returnAux.AppendLine("Costo de la Estadia: " + (DateTime.Now.Hour - base.ingreso.Hour) * Automovil.valorHora);
            return returnAux.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Automovil);
        }
    }
}
