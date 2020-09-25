using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada {Local,Provincial,Todas};
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino=nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public static int OrdernarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int returnAux = 0;
            if(llamada1.duracion<llamada2.duracion)
            {
                returnAux = -1;
            }
            else if(llamada1.duracion>llamada2.duracion)
            {
                returnAux = 1;
            }
            return returnAux;
        }
        public string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("La duracion de la llamada es: " + this.duracion);
            returnAux.AppendLine("El numero de origen de la llamada es: " + this.nroOrigen);
            returnAux.AppendLine("El numero de destino de la llamada es: " + this.nroDestino);
            return returnAux.ToString();
        }
    }
}
