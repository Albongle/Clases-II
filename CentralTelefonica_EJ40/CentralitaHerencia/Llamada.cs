using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada {Local,Provincial,Todas};
        #endregion

        #region Constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino=nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Propiedades
        public abstract float CostoLlamada { get; }
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

        #endregion

        #region Metodos
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
        protected virtual string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("La duracion de la llamada es: " + this.duracion);
            returnAux.AppendLine("El numero de origen de la llamada es: " + this.nroOrigen);
            returnAux.AppendLine("El numero de destino de la llamada es: " + this.nroDestino);
            return returnAux.ToString();
        }
        public bool Guardar()
        {
            this.ToString();
            return true;
        }
        public string Leer()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && (l1.nroDestino == l2.nroDestino) && (l1.nroOrigen == l2.nroOrigen);
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return (l1 == l2);
        }
        #endregion

    }
}
