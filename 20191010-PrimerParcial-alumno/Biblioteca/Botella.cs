using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        public enum Tipo { Vidrio, Plastico };

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            if (capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            this.contenidoML = contenidoML;
            this.capacidadML = capacidadML;
            this.marca = marca;
        }
        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public float ProcentajeContenido
        {
            get
            {
                return ((float)this.Contenido / (float)this.capacidadML) * 100;
            }
        }
        public abstract int ServirMedida();
        protected virtual string GenerarInforme()
        {
            StringBuilder returAux = new StringBuilder();
            returAux.AppendLine("Marca: " + this.marca);
            returAux.AppendLine("Capacidad Litros: " + this.CapacidadLitros);
            returAux.AppendLine("Contenido ML: " + this.Contenido);
            return returAux.ToString();
        }
        public override string ToString()
        {
            return this.GenerarInforme();
        }

    }
}
