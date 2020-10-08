using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;
        public Vehiculo (string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        public abstract string ConsultarDatos();
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(value.Length>=6)
                {
                    this.patente = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Patente: {0}", this.patente);
        }
        public virtual string ImprimirTicket()
        {
            StringBuilder returnAux =new StringBuilder();
            returnAux.AppendLine(this.ToString());
            returnAux.AppendLine("Hora de ingreso: " + this.ingreso);
            return returnAux.ToString();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.patente == v2.patente) && v1.Equals(v2);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
