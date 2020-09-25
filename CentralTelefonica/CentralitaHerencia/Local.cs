using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local :Llamada
    {
        protected float costo;
        public Local (Llamada llamada,float costo)
            :base(llamada.Duracion, llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion,string destino, float costo)
            :base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine(base.Mostrar());
            returnAux.AppendLine("El costo de la llamada local es: " + this.CostoLlamada);
            return returnAux.ToString();
        }
        private float CalcularCosto()
        {
            return this.costo *this.duracion;
        }
    }
}
