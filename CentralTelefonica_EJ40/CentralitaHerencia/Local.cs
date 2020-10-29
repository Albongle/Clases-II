using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local :Llamada, IGuardar<string>
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Constructores
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
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public string RutaDeArchivo
        {
            get
            {
                return string.Empty;
            }
            set
            {

            }
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
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
        public override bool Equals(object obj)
        {
            return obj is Local;    
        }
        public override string ToString()
        {
            return this.Mostrar();
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
    }
}
